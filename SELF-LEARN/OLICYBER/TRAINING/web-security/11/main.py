import requests

url_post = 'http://web-11.challs.olicyber.it/login'
url = 'http://web-11.challs.olicyber.it/flag_piece'
payload = {"username": "admin", "password": "admin"}
session = requests.Session()

login_response = session.post(url_post, json=payload)
login_data = login_response.json()
csrf = login_data["csrf"]

for index in range(4):
    piece_response = session.get(url, params={"index": index, "csrf": csrf})
    piece_data = piece_response.json()

    print(piece_data["flag_piece"], end="")
    csrf = piece_data["csrf"]