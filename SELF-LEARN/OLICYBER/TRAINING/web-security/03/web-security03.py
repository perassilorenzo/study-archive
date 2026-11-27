import requests

url = "http://web-03.challs.olicyber.it/flag"
headers = {'X-Password' : 'admin'}

print(requests.get(url, headers=headers).text)