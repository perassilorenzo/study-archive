/*
    richiamo tutte le #INCLUDE che usiamo solitamente nei progetti
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

/*
    creo l'eleno delle definisizioni delle funzioni / procedure
*/

// legge stringa generica da tastiera e l'alloca dinamicamente
char *readString();

// rialloca la stringa ricevuta come parametro
char *copyString(char *s);

// inverte la string ricevuta come parametro riallocandola dinamicamente
char *reverseString(char *s);

// concatena due  stringhe ricevuta come parametro in una nuova stringa allocata dinamicamente
char *concatenateStrings(char *s1, char *s2, char space);

// converte una stringa ricevuta come parametro in un numero intero
int stringToInt(char *s);

// converte un numero intero ricevuto come parametro in una nuova stringa allocata dinamicamente 
char *intToString(int n);

// converte una stringa ricevuta come parametro tutta in maiuscolo
char toUpperCase(char *s);

// converte una stringa ricevuta come parametro tutta in minuscolo
char toLowerCase(char *s);

// elimina i caratteri "inutili" della stringa ricevuta come parametro
void clearString(char *s);

// genera un numero casuale intero tra a e b inclusi
int randomInt(int a, int b);
