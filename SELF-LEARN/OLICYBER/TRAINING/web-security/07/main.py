import requests

url = 'http://web-07.challs.olicyber.it/'

print(requests.head(url).headers)