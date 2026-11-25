# i dizionart, dict

my_dict = {"my_key" : "my_value", "age" : "29", 3.14 : "pi greco", "primi" : [2, 3, 5, 7]}

# i dizionari sono composti da chiavi che corrispondono ai valori e le chiavi sono i corrispettivi indici per le liste

print( my_dict["my_key"])       # output: my_value

my_dict[ "my_key"] = "my_new_value"     #per sostituirlo / aggiornarlo

print( my_dict["my_key"])       # output: my_new_value

my_dict[ "new_key"] = "new_value"       # per aggiungere una nuova chiave e un nouvo valore corrispondente ad essa

# per verificare se è presente una chiave è presente o meno in un dizionario possiamo utilizzare gli operatori in e not in

"spam" in my_dict       # output: False

"age" in my_dict        # output: True

29 in my_dict       # output: False

del my_dict["my_key"]       # per eliminare la coppia della chiave e del valore


ita_eng = {"ciao" : "hello", "arrivederci" : "goodbye", "uova" : "eggs", "gatto" : "cat", "arancia" : "orange"}

print( ita_eng.keys() )       # output: ciao, arrivederci, uova, gatto, arancia

print(ita_eng.values())      # per ottenere invece solo i valori e non le chiovi

print(ita_eng.items())      # per ottenere una lista e rappresentate come tuple anche se non è una lista vera e propria ma un dict_items, output: [(ciao, hello), (arrivederci, goodbye), ...]

print(list(item))      # output: [(ciao, hello), (arrivederci, goodbye),...]

# cicli for

for key in ita_eng.keys():
    print(key)

ita_eng.get("spam", "chiave non trovata!")      # output: chiave non trovata!

ita_eng.get("ciao", "chiave non trovata!")      # output: hello

# setdefault()

ita_eng.setdefault("birra", "beer")     # output: beer, e adesso nel dizionario è anche presente questa copia

ita_eng.setdefault("ciao", "hi")        # output: hello, perché questo funziona solo se non c'è un valore assegnato ad una chiave