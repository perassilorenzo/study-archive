#If

age=int(input('Quanti anni hai?\n'))
if age<18:
    print('Sei minorenne')
else:
    print('Sei maggiorenne')

#Elif

license=input('Hai la patente? Sì/No\n')
if age>=18 and license=='Sì':
    print('Puoi guidare una macchina')
elif age>=18 and license=='No':
    print('Puoi prendere la patente')
else:
    print('Devi essere maggiorenne')