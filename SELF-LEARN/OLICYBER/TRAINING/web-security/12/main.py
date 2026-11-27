# Importa requests, usato per inviare richieste HTTP.
import requests
# Importa BeautifulSoup, usato per analizzare e cercare elementi nell'HTML.
from bs4 import BeautifulSoup

# Indirizzo della pagina web da cui scaricare il contenuto.
url = 'http://web-12.challs.olicyber.it/'

# Scarica la pagina e passa il testo HTML a BeautifulSoup.
# 'html.parser' indica il parser da usare per interpretare l'HTML.
soup = BeautifulSoup((requests.get(url).text), 'html.parser')
# find('pre') cerca il primo tag <pre>. get_text estrae il testo,
# mentre strip=True rimuove gli spazi e le nuove righe ai bordi.
# find_all('pre') cercherebbe tutti i tag <pre> e restituirebbe una lista.
# print mostra il testo estratto nel terminale.
print(soup.find('pre').get_text(strip=True))