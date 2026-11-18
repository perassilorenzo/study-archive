#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// prototipes
char * StringCopy(char s[]);

int main()
{
    char originalString[50  + 1];
    char *pointerString;  

    printf("\nEsercizio 9 : copia di una Stringa in un Area Dinamica");

    // Input della Stringa
    printf("\n\nInserisci una Stringa >>> ");
    fflush(stdin);
    gets(originalString);

    printf("\n\nStringa Originale : \"%s\" ", originalString);

    pointerString = StringCopy(originalString);
    printf("\n\nStringa Copiata : \"%s\" ", pointerString);

    free(pointerString);

    printf("\n\n");

    return 0;

}

char * StringCopy(char s[])
{
    int stringLength = strlen(s);
    char *pointerCopyString;

    pointerCopyString = (char *)malloc(stringLength * sizeof(char));

    // strcpy(pointerCopyString, s);
    for(int i = 0; i < stringLength; i++)
    {
        if (s[i] >= 'a' && s[i] <= 'z')
            //s[i] -= 'a' - 'A';
            s[i] += 'A' - 'a';

        pointerCopyString[i] = s[i];
    }
    //pointerCopyString[i] = '\0';
    pointerCopyString[stringLength] = '\0';

    return pointerCopyString;
}

/*
    * APPUNTI
    *
    * StringCopy riceve una stringa s[] e restituisce un puntatore a una
    * nuova stringa allocata dinamicamente.
    *
    * strlen(s) conta i caratteri della stringa, senza contare '\0'.
    *
    * malloc(stringLength * sizeof(char)) alloca memoria per i caratteri.
    * sizeof(char) vale 1 byte.
    *
    * Il ciclo scorre tutti i caratteri di s:
    * for (int i = 0; i < stringLength; i++)
    *
    * La condizione:
    * s[i] >= 'a' && s[i] <= 'z'
    * verifica se il carattere in posizione i e una lettera minuscola.
    *
    * La sottrazione di 32:
    * s[i] += 'A' - 'a';
    * trasforma una minuscola in maiuscola:
    * 'a' -> 'A', 'b' -> 'B', 'z' -> 'Z'.
    *
    * Quindi il carattere viene copiato nella memoria dinamica:
    * pointerCopyString[i] = s[i];
    *
    * Alla fine si aggiunge il terminatore della stringa:
    * pointerCopyString[stringLength] = '\0';
    *
    * Nel main, pointerString riceve l'indirizzo della nuova stringa:
    * pointerString = StringCopy(originalString);
    *
    * %s serve a stampare la stringa:
    * printf("%s", pointerString);
    *
    * free libera la memoria dinamica:
    * free(pointerString);
    *
    * Nota: per contenere anche '\0', l'allocazione dovrebbe usare
    * (stringLength + 1) * sizeof(char).
*/