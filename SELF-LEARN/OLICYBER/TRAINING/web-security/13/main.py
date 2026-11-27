import requests
from bs4 import BeautifulSoup

url = 'http://web-13.challs.olicyber.it/'
soup = BeautifulSoup((requests.get(url).text), 'html.parser')

print(requests.get(url).text)
for span in soup.find_all("span", class_="red"):
    print(span.get_text(strip=True), end="")