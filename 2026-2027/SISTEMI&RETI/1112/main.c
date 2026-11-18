#include <stdio.h>
#include <stdlib.h>

int main()
{

    int *pi;
    char *pc;

    printf("\nEsercizio 6: allocazione Dinamica della Memoria");

    /**
     * malloc()
     * 
     * restituisce sempre un puntatore a VOID
     * 
     * - 1° : cast al Tipo di Allocazione richiesto;
     * - 2° : istruzione MALLOC
     * - 3° : la dimesione dell'Area di Memoria
     * 
    */
    
    pi = (int *)malloc(sizeof(int));
    *pi = 15;

    pc = (char *)malloc(sizeof(char));
    *pc = 'Z';

    printf("\nNumero %d - Indirizzo %p", *pi, pi);
    printf("\nCarattereo '%c' - Indirizzo %p", *pc, pc);

    free(pi);
    free(pc);

    printf("\n\n");
    
    return 0;
}

/*

    * APPUNTI SULLA LINEA:
    * pi = (int *)malloc(sizeof(int));
    *
    * - pi e' una variabile puntatore a intero. Contiene l'indirizzo
    *   di una zona di memoria in cui e' possibile memorizzare un int.
    *
    * - sizeof(int) restituisce la dimensione in byte di un int.
    *
    * - malloc(sizeof(int)) alloca dinamicamente una zona di memoria
    *   abbastanza grande da contenere un int.
    *
    * - malloc restituisce un puntatore generico void *, quindi
    *   (int *) converte quel puntatore nel tipo int *.
    *
    * - L'operatore = assegna a pi l'indirizzo della memoria allocata.
    *
    * ESEMPIO DI ASSEGNAZIONE:
    *
    * pi = (int *)malloc(sizeof(int));
    * *pi = 15;
    *
    * Schema:
    * pi  -> indirizzo della memoria allocata
    * *pi -> 15, cioe' il contenuto presente a quell'indirizzo
    * &pi -> indirizzo della variabile puntatore pi
    *
    * Rappresentazione semplificata:
    *
    * &pi = indirizzo della variabile pi
    * +----------------+
    * | pi             |
    * | 0x1000         | ---> indirizzo contenuto nella variabile pi
    * +----------------+
    *                            |
    *                            v
    *                        0x1000
    *                        +------+
    *                        | 15   | <-- *pi
    *                        +------+
    *
    * Quindi:
    * pi  contiene 0x1000;
    * *pi vale 15;
    * &pi indica dove la variabile pi e' memorizzata.
    *
    * Per accedere al valore:
    * *pi rappresenta il contenuto dell'indirizzo contenuto in pi.
    *
    * Dopo free(pi), la memoria viene rilasciata e pi non deve essere
    * usato finche' non viene inizializzato di nuovo. Una buona pratica:
    *
    * free(pi);
    * pi = NULL;
    *
    * Prima di utilizzare pi, sarebbe inoltre utile controllare che
    * malloc abbia avuto successo:
    *
    * pi = (int *)malloc(sizeof(int));
    * if (pi == NULL) {
    *     printf("Errore di allocazione della memoria");
    *     return 1;
    * }
*/