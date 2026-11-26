from os import environ
from http import HTTPStatus
from flask import Flask, request, Response


app = Flask(__name__)


@app.route("/private-resource")
def private_resource():
    if request.headers.get("X-Password") == "admin":
        return Response(environ["FLAG"], mimetype="text/plain", status=HTTPStatus.OK)
    else:
        return Response("Unauthorized", mimetype="text/plain", status=HTTPStatus.UNAUTHORIZED)


if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
