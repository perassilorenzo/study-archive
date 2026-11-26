import requests

url = "http://web-04.challs.olicyber.it/users"

print(requests.get(url, headers = {"Accept" : "application/xml"}).text)