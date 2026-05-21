import { open } from 'sqlite';
import sqlite3 from 'sqlite3';

const db = open({
	filename: './database.db',
	driver: sqlite3.Database
});

export default db;
