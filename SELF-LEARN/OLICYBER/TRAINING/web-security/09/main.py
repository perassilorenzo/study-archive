import requests

url = 'http://web-09.challs.olicyber.it/login'
payload = {"username": "admin", "password":  "admin"}

print(requests.post(url, json=payload).text)