#liste
my_list=[9.81, "pasta", 22, 44, 3.14]

new_list=["asd", my_list]

#per selezionare un elemento devo scrivere il numero dell'indice (sono come vettori: partono sempre da [0], [1],...)

print(my_list[1])

#per selezionare gli ultimi elementi della lista bisogna indicare gli indici al negativo [-1], [-2]

print(my_list[-1])      #3.14

#slicing = affettare

primi= [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47]

print(primi[4:10])      #[11, 13, 17, 19, 23, 29]
print(primi[10])        # =31

fetta = primi[4:10]     #fetta= [11, 13, 17, 19, 23, 29]

print(primi[4: ])       #per ottere tutti i numeri da quello con indice 4 all'ultimo senza sapere magari la lunghezza del vettore
print(primi[ :5])       #per ottere tutti numeri prima di quello con indice pari a 5 non compreso ovviamente

primi= [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47]
match= 11

for el in primi:
    if el == match:
        output= str(el) + " == " + str(match)
        print("March! "+ output)
    else:
        print(el)

#medodi delle liste

spesa=["riso", "pollo", "verdura"]
spesa += "sapone"
print(spesa)        #spesa= ["riso", "pollo", "verdura", "s", "a", "p", "o", "n", "e"]

#soluzioni: metodi
# tipo_di_dato.nome_metodo(eventuali_parametri)

spesa.append("sapone")
print(spesa)        #spesa= ["riso", "pollo", "verdura", "sapone"]

spesa_extra= ["camicia", "copri volante"]
spesa.extend(spesa_extra)
print(spesa)        #spesa= ["riso", "pollo", "verdura", "sapone", "camicia", "copri volante"]


alfabeto= ["z", "u", "a", "c", "v"]
alfabeto.sort()       #per ordinare la lista
print(alfabeto)     #alfabeto=[a, c, u, v, z]

numeri= [32, 1, 15, 2, 22, 23, 56, 88]
numeri.sort()
print(numeri)       #numeri= [1, 2, 15, 22, 23, 32, 56, 88]

numeri.sort(reverse= True)
print(numeri)       #numeri= [88, 56, 32, 22, 15, 2, 1]

numeri= [32, 1, 15, 2, 22, 23, 56, 88]

numeri.index(56)        #per ottenere l'indice dell'elemento
print(numeri.index(56))     # numeri.index(56) = 6

spesa=["riso", "pollo", "verdura"]
spesa[1]= "tacchino"        #per sostituire un elemento con un altro

del spesa [0]       #per eliminare totalmente l'elemento, ad esempio è stato eliminato "riso"


new_list= [True, None, "poker", 4.20, 1945]
new_list.pop()      #per eliminare l'ultimo elemento, in questo caso 1945 --> new_list= [True, None, "poker", 4.20]

new_list.remove(None)       #per rimuovere un elemento specifico --> new_list= [True, "poker", 4.20]