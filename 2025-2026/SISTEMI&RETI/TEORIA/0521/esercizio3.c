#include <stdlib.h>
#include <stdio.h>

int num = 3;

int calcola(int a, int b){
    int* ris = malloc(sizeof(int));
    *ris = a + b + num;
    int val = *ris;
    free(ris);
    return val;
}

int main(){
    int val1 = 2;
    int val2 = 5;
    int esito = calcola(val1,val2);
    return 0;
}

/*

RAM
------------------------
STACK:

    // main()
    //     val1 = 2
    //     val2 = 5
    //     esito = 10

----

    // calcola(a,b)
    //     a = 2
    //     b = 5
    //     ris = indirizzo memoria HEAP
    //     val = 10

------------------------
HEAP:
    
    ris --> 10
    (memoria poi liberata con free)

------------------------
DATA:
    num = 3

------------------------
CODICE:
    main()
    calcola()
    malloc()
    free()

------------------------

*/