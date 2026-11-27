import json
from os import environ
from uuid import uuid4
from textwrap import dedent
from http import HTTPStatus
from flask import Flask, request, Response, render_template


app = Flask(__name__)


@app.route("/")
def login():
    return render_template("index.html", flag=environ["FLAG"])


if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
