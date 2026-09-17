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

    // read - 1
    fp = fopen("file.txt", "r");
    fscanf(fp, "%s", name);
    fclose(fp);
    printf("\nNome: \"%s\"", name);

    // read - 2
    fp = fopen("file.txt", "r");
    while(fgets(name, 30, fp) != NULL
          printf("\nNome: \"%s\"", name);
    fclose(fp);

    // read - 3
    fp = fopen("file.txt", "r");
    while(!feof(fp)){
        fscanf(fp, "%s", name);
        printf("\nNome: \"%s\"", name);
    }
    fclose(fp);

    // controllo file elenco
    fp = fopen("list.txt", "r");
    if (fp == NULL)
    {
        fclose(fp);
        fp = fopen("list.txt", "w");
    }
    fclose(fp);


    printf("\n\n");
}
