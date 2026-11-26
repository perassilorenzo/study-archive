import requests

# Una sola sessione conserva i cookie tra una richiesta e l'altra.
session = requests.Session()

url_token = "http://web-06.challs.olicyber.it/token"
url_flag = "http://web-06.challs.olicyber.it/flag"

# Il server invia il token come cookie; la sessione lo memorizza.
session.get(url_token)

# La stessa sessione invia il cookie a /flag; stampiamo la risposta.
print(session.get(url_flag).text)
