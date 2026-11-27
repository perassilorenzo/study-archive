import requests

url = "http://web-10.challs.olicyber.it/"

# Allow indica i metodi che il server dichiara di supportare.
options_response = requests.options(url)
print("Allow:", options_response.headers.get("Allow"))

# PUT e PATCH non sono elencati; il server li riceve comunque, ma può gestirli male.
print(requests.put(url).headers)
print(requests.patch(url).headers)

# 500 indica un errore interno, non una richiesta riuscita.
