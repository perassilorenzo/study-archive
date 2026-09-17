#include <stdio.h>
#include <stdlib.h>

void main()
{
    FILE *fp; //puntatore che contiene l'indirizzo del file
    char name[30+1];

    fp = fopen("file.txt", "r");
    if (fp == NULL)
    {
        fclose(fp);
        fp = fopen("file.txt", "w");
        printf("\nFile creato con successo\n");
    }
    else
        printf("\nFile esistente\n");
    fclose(fp);

    // insert
    fp = fopen("file.txt", "w");

    printf("\nInserisci il nome ==> ");
    //scanf("%s", name);
    gets(name);

    fprintf(fp, "%s", name);


    fclose(fp);
    printf("\n\n");
}
