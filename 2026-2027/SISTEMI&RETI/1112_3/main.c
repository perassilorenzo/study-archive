#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char * copia(char s[]);

int main()
{

    char strORG[50  + 1];
    char *ps;  

    printf("\nEsercizio 9 : copia si una Stringa in un Area Dinamica");

    // Input della Stringa
    printf("\n\nInserisci una Stringa ==> ");
    fflush(stdin);
    gets(strORG);

    printf("\n\nStringa Originale : \"%s\" ", strORG);

    ps = copia(strORG);
    printf("\n\nStringa Copiata : \"%s\" ", ps);

    free(ps);

    printf("\n\n");

    return 0;

}

char * copia(char s[])
{

    int lunS;
    char *pSCopia;
    char ch;
    int I;

    lunS = strlen(s);
    pSCopia = (char *)malloc(lunS * sizeof(char));

    // strcpy(pSCopia, s);
    for(I=0; I < lunS; I++)
    {
        ch = s[I];
        if (ch >= 'a' && ch <= 'z')
            //ch -= 'a' - 'A';
            ch += 'A' - 'a';
        pSCopia[I] = ch;
    }
    //pSCopia[I] = '\0';
    pSCopia[lunS] = '\0';

    return pSCopia;
}