import requests
from bs4 import BeautifulSoup, Comment

url = 'http://web-14.challs.olicyber.it/'
response = requests.get(url)
soup = BeautifulSoup(response.text, 'html.parser')
                            
# Il parametro string esamina i nodi di testo; la lambda seleziona solo
# quelli che sono commenti HTML. Il risultato è una lista di commenti.
comments = soup.find_all(string=lambda text: isinstance(text, Comment))
for comment in comments:
    print(comment.strip())