import express from 'express';
import bodyParser from 'body-parser';
import cookieParser from 'cookie-parser';

const app = express();

app.use(cookieParser());

app.options('/', bodyParser.raw({ type: 'text/plain' }), (req, res) => {
	if (req.query['we_like'] !== 'flags') {
		res.send('nope :)');
		return;
	}

	if (req.headers['give-me'] !== 'the-flag') {
		res.send('nope :)');
		return;
	}

	if (req.cookies.session_id !== 'the_session') {
		res.send('nope :)');
		return;
	}

	try {
		// the content type NEEDS TO BE text/plain
		if (req.body.toString() !== 'pretty please :(') {
			res.send('nope :)');
			return;
		}
	} catch {
		res.send('nope :)');
		return;
	}

	res.send(process.env.FLAG || "flag{REDACTED}");
});

app.use('/', async (req, res) => {
	res.send('nope :)');
});

app.listen(3000, '0.0.0.0', () => {
	console.log('Listening on 3000'.toString());
});
