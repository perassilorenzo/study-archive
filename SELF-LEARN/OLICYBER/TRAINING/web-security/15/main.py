import requests
from bs4 import BeautifulSoup 
import re

url_base = 'http://web-15.challs.olicyber.it/'
soup = BeautifulSoup(requests.get(url_base).text, 'html.parser')

def scaping_file(url):
    response = requests.get(url)
    return response.text

for link in soup.find_all("link", rel="stylesheet"):
    href = link["href"]
    href = href.rsplit("/", 1)[-1]
    
    css = scaping_file(url_base + href)
    print(re.search(r'flag\{[^}]*\}', css, re.IGNORECASE))

for script in soup.find_all("script"):
    src = script["src"]
    src  = src.rsplit("/", 1)[-1]
    
    js = scaping_file(url_base + src)
    print(re.search(r'flag\{[^}]*\}', js, re.IGNORECASE))
