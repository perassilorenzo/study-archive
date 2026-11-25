import assert from 'assert';
import express from 'express';
import dbPromise from './database.js';
import type { Database } from 'sqlite';
import crypto from 'crypto';
import cookieParser from 'cookie-parser';
import bodyParser from 'body-parser';
import DOMPurify from 'isomorphic-dompurify';
import hashcash from '@mawoka/hashcash';

function isString(value: unknown): value is string {
	return !!value && typeof value === 'string';
}

declare global {
	namespace Express {
		interface Request {
			db: Database;
			session: { user_id: number; username: string; pow: string } | null;
		}
	}
}

const app = express();

app.use(express.json());
app.set('view engine', 'ejs');

// this initializes the database
app.use(async (req, res, next) => {
	try {
		req.db = await dbPromise;

		await req.db.run(`CREATE TABLE IF NOT EXISTS users (
			id INTEGER PRIMARY KEY,
			username VARCHAR(255) UNIQUE NOT NULL,
			password VARCHAR(255) NOT NULL,
			pow VARCHAR(255) NOT NULL
		);`);

		await req.db.run(`CREATE TABLE IF NOT EXISTS tokens (
			token VARCHAR(255) PRIMARY KEY,
			user_id INT NOT NULL,
			FOREIGN KEY (user_id) REFERENCES users(id)
		);`);

		await req.db.run(`CREATE TABLE IF NOT EXISTS notes (
			id VARCHAR(255) PRIMARY KEY,
			owner INT NOT NULL,
			content LONG TEXT NOT NULL,
			FOREIGN KEY (owner) REFERENCES users(id)
		);`);

		next();
	} catch (err) {
		console.error(err);
		res.status(500).send('Database connection failed');
	}
});

app.use(cookieParser());

// verifies the session cookie and token
app.use((req, res, next) => {
	const authCookie = req.cookies['session'];
	if (!authCookie) {
		req.session = null;
		next();
		return;
	}

	if (!isString(authCookie)) {
		req.session = null;
		next();
		return;
	}
	req.db
		.get(`SELECT * FROM tokens LEFT JOIN users ON tokens.user_id=users.id WHERE token = ?`, [authCookie])
		.then((data) => {
			if (!data) {
				req.session = null;
			} else {
				req.session = {
					user_id: data.user_id,
					username: data.username,
					pow: data.pow
				};
			}
			next();
		})
		.catch((err) => {
			res.status(500).send('Database error');
			console.error(err);
		});
});

app.get('/', (req, res) => {
	if (req.session) {
		res.redirect('/notes');
	} else {
		res.render('index');
	}
});

app.get('/logout', (req, res) => {
	res.clearCookie('session');
	res.redirect('/');
});

app.post('/register', bodyParser.urlencoded(), async (req, res) => {
	assert(isString(req.body.username), 'Username is required');

	const password = crypto.randomUUID();
	try {
		await req.db.run(`INSERT INTO users (id, username, password, pow) VALUES (NULL, ?, ?, ?)`, [
			req.body.username,
			password,
			crypto.randomBytes(4).toString('hex')
		]);

		const data = await req.db.get(`SELECT * FROM users WHERE username = ?`, [req.body.username]);

		// session token, saved in db and stored in a cookie
		const token = crypto.randomUUID();
		await req.db.run(`INSERT INTO tokens (token, user_id) VALUES (?, ?)`, [token, data.id]);

		res.cookie('session', token);

		res.render('new', {
			flash: `Your account has been created with password ${password}`
		});
		return;
	} catch (err) {
		if ((err as any).code === 'SQLITE_CONSTRAINT') {
			res.status(400).send('Username already exists');
			return;
		}
		res.status(500).send('Database error');
		console.error(err);
		return;
	}
});

app.post('/login', bodyParser.urlencoded(), async (req, res) => {
	assert(isString(req.body.username), 'Username is required');
	assert(isString(req.body.password), 'Password is required');

	try {
		const data = await req.db.get(`SELECT * FROM users WHERE username = ? AND password = ?`, [
			req.body.username,
			req.body.password
		]);

		if (!data) {
			res.status(401).send('Invalid username or password');
			return;
		}

		// session token, saved in db and stored in a cookie
		const token = crypto.randomUUID();
		await req.db.run(`INSERT INTO tokens (token, user_id) VALUES (?, ?)`, [token, data.id]);

		res.cookie('session', token);
		res.redirect('/notes');
		return;
	} catch (err) {
		res.status(500).send('Database error');
		console.error(err);
		return;
	}
});

app.get('/note/:id', async (req, res) => {
	try {
		const data = await req.db.get(
			`SELECT notes.*, users.username FROM notes INNER JOIN users ON notes.owner=users.id WHERE notes.id = ?`,
			[req.params.id]
		);

		// we don't want any xss, so we sanitize the user input using DOMPurify
		let content = DOMPurify.sanitize(data.content);
		// adding paragraphs
		content = content
			.split('\n')
			.map((line) => `<p class="mb-3">${line}</p>`)
			.join('\n');

		// bold tag
		content = content.replaceAll(/\[b\]([^[]+)\[\/b\]/g, '<strong>$1</strong>');
		// italic tag
		content = content.replaceAll(/\[i\]([^[]+)\[\/i\]/g, '<em>$1</em>');
		// underline tag
		content = content.replaceAll(/\[u\]([^[]+)\[\/u\]/g, '<u>$1</u>');
		// strikethrough tag
		content = content.replaceAll(/\[s\]([^[]+)\[\/s\]/g, '<s>$1</s>');
		// link tag
		content = content.replaceAll(
			/\[link=([^\]]+)\]([^[]+)\[\/link\]/g,
			'<a href="$1" target="_blank" class="text-blue-700 underline hover:no-underline">$2</a>'
		);
		// image tag
		content = content.replaceAll(/\[img\]([^[]+)\[\/img\]/g, (_, src) => {
			if (src.includes('"')) {
				return 'nice try :)';
			}
			return `<img src="${src}" class="max-w-full h-auto" />`;
		});

		res.render('note', {
			username: req.session?.username,
			id: req.params.id,
			owner: data.username,
			content: content
		});
	} catch (err) {
		res.status(500).send('Database error');
		console.error(err);
		return;
	}
});

app.use((req, res, next) => {
	if (!req.session) {
		res.clearCookie('session');
		res.redirect('/');
		return;
	}
	next();
});

app.get('/new', (req, res) => {
	res.render('new', { flash: null });
});

app.post('/new', bodyParser.urlencoded(), async (req, res) => {
	assert(isString(req.body.content), 'Content is required');

	try {
		const id = crypto.randomUUID();
		await req.db.run(`INSERT INTO notes (id, owner, content) VALUES (?, ?, ?)`, [
			id,
			req.session!.user_id,
			req.body.content
		]);

		res.redirect(`/note/${id}`);
	} catch (err) {
		res.status(500).send('Database error');
		console.error(err);
		return;
	}
});

app.get('/notes', async (req, res) => {
	try {
		const data = await req.db.all(`SELECT id FROM notes WHERE owner=?`, [req.session!.user_id]);

		res.render('home', {
			username: req.session!.username,
			notes: data
		});
	} catch (err) {
		res.status(500).send('Database error');
		console.error(err);
		return;
	}
});

app.get('/report', (req, res) => {
	res.render('report', {
		pow: req.session!.pow,
		flash: null
	});
});

app.post('/report', bodyParser.urlencoded(), async (req, res) => {
	assert(isString(req.body.link), 'Link is required');
	assert(isString(req.body.pow), 'Proof of Work is required');

	try {
		// verify pow
		if (!hashcash.check(req.body.pow, req.session!.pow, 26)) {
			res.send('Invalid hashcash');
			return;
		}
		const newPow = crypto.randomBytes(4).toString('hex');
		await req.db.run(`UPDATE users SET pow=? WHERE id=?`, [newPow, req.session!.user_id]);
		req.session!.pow = newPow;
	} catch (err) {
		res.status(500).send('Database error');
		console.error(err);
		return;
	}

	try {
		// trigger the headless admin to visit your page
		await fetch(`http://${process.env.HEADLESS_HOST}`, {
			method: 'POST',
			headers: {
				'Content-Type': 'application/json',
				'X-Auth': process.env.HEADLESS_AUTH!
			},
			body: JSON.stringify({
				actions: [
					{
						type: 'request',
						url: `${process.env.DOMAIN}/`,
						method: 'GET'
					},
					{
						type: 'set-cookie',
						name: 'flag',
						value: process.env.FLAG || "flag{REDACTED}"
					},
					{
						type: 'request',
						url: req.body.link,
						timeout: 5
					},
					{ type: 'sleep', time: 5 }
				]
			})
		});

		res.render('report', {
			pow: req.session!.pow,
			flash: 'An admin will visit your page'
		});
	} catch (err) {
		res.status(500).send('Headless error');
		console.error(err);
		return;
	}
});

app.listen(3000, '0.0.0.0', () => {
	console.log('Server is running on http://localhost:3000');
});
