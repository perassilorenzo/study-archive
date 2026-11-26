from os import environ
from http import HTTPStatus
from flask import Flask, request, Response


app = Flask(__name__)


@app.route("/server-records")
def server_records():
    try:
        id = request.args["id"]
    except KeyError:
        return Response("Missing query parameter 'id'", mimetype="text/plain", status=HTTPStatus.BAD_REQUEST)
    if id.casefold() == "flag":
        return Response(environ["FLAG"], mimetype="text/plain", status=HTTPStatus.OK)
    else:
        return Response(f"Record '{id}' not found", mimetype="text/plain", status=HTTPStatus.NOT_FOUND)


if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
