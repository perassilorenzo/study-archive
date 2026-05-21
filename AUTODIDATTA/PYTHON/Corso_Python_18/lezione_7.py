#Il ciclo while

count=0

while count <=10:
    print(count)
    count+=1 # count= count+1

#Break

run= True
stop= 1000
count= 0

while run== True:
    print(count)
    count+=1
    if count>stop:
        print('End loop')
        break

#Continue

run= True
skip= 3
count= 0

while count<10:
    count+=1
    if count == skip:
        print('Ho saltato '+str(skip))
        continue
    print(count)
