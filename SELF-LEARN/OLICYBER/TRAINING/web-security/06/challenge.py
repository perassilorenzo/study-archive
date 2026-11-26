import json
import sqlite3
from os import environ
from uuid import uuid4
from textwrap import dedent
from http import HTTPStatus
from flask import Flask, request, Response


app = Flask(__name__)

with sqlite3.connect("challenge.db") as db:
    db.execute("CREATE TABLE IF NOT EXISTS tokens(token TEXT PRIMARY KEY)")


@app.route("/token")
def token():
    token = str(uuid4())
    with sqlite3.connect("challenge.db") as db:
        db.execute("INSERT INTO tokens(token) VALUES (?)", (token,))
    response = Response("", status=HTTPStatus.NO_CONTENT)
    response.set_cookie("token", token)
    return response


@app.route("/flag")
def flag():
    try:
        token = request.cookies["token"]
    except KeyError:
        return Response("Missing token cookie. Unauthorized", mimetype="text/plain", status=HTTPStatus.UNAUTHORIZED)

    with sqlite3.connect("challenge.db") as db:
        row = db.execute("SELECT NULL FROM tokens WHERE token=?", (token,))

    if row is None:
        return Response("Bad token cookie. Unauthorized", mimetype="text/plain", status=HTTPStatus.UNAUTHORIZED)

    return Response(environ["FLAG"], mimetype="text/plain", status=HTTPStatus.OK)


if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
