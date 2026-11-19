#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// protoripes
char * subString(int start, int end, char *string);

int main(){
    printf("\n\nEsercizio 11: parsing di una stringa con le 4 opzioni");

    char *pointerString;
    char *pointerCopyString;
    
    char *value1;
    char *value2;
    
    char sign;
    int i = 0, found = 0, pos = 0, stringLength;

    printf("\nInserisci una stringa >>> ");
    fflush(stdin);
    gets(pointerString);

    // ci salviamo la stringa iniziale
    strcpy(pointerCopyString, pointerString);

    stringLength = strlen(pointerString);

    // cerco nella stringa il tipo di operazione [+; -; *; /]
    while (found && i < stringLength){
        char c = pointerString[i];
        if (c == '+' || c == '-' || c == '*' || c == '/'){
            found = 1;
            sign = pointerString[i];
            pos = i;
        }
        else
            i++;
    }

    // identifico i due numeri
    value1 = pointerString;
    value2 = pointerString;

    strcpy(value1, subString(0, pos, pointerString));
    strcpy(value2, subString(pos + 1, stringLength, pointerString))

    strcpy( , );

    return 0;
}

char * subString(int start, int end, char *string){
    char *stringDestination;

    stringDestination = (char *)malloc((end - start + 1) * sizeof(char));

    for(int i = start, i < end, i++)
        stringDestination[i - start] = string[i];

    return stringDestination
}