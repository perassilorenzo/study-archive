#include <stdio.h>
#include <stdlib.h>

void main()
{
    FILE *fp; //puntatore che contiene l'indirizzo del file
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
}
