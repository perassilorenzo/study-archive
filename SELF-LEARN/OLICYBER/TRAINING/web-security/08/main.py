import requests

url = 'http://web-08.challs.olicyber.it/login'
payload = {"username": "admin", "password": "admin"}

print(requests.post(url, data=payload).text)