// programma per trovare il maggiore tra due numeri
// Perassi Lorenzo

// librerie:
# include <stdio.h>
# include <math.h>

// funzione principale:

int main () {

    int a, b, max; // dichiraro le variabili

    printf("Inserire il primo numero: ");
    scanf("%d", &a);

    printf("Inserire il secondo numero: ");
    scanf("%d", &b);

    if ( a == b )
            printf("I numeri sono uguali. \n");

    else
    {
        if ( a > b )
            max = a;

        else
            max = b;

    }

     printf("Il maggiore e': %d", max );

     return 0;
}
