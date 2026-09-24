#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void main()
{
    FILE *fp; //puntatore che contiene l'indirizzo del file
    char name[30+1];
    char subject[20+1];

    fp = fopen("file.txt", "r");
    if (fp == NULL){
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
    while(fgets(name, 30, fp) != NULL){
        printf("\nNome: \"%s\"", name);
    }
    fclose(fp);

    // read - 3
    fp = fopen("file.txt", "r");
    fscanf(fp, "%s", name);
    while(!feof(fp)){
        printf("\nNome: \"%s\"", name);
        fscanf(fp, "%s", name);
    }
    fclose(fp);

    // controllo file elenco
    fp = fopen("list.txt", "r");
    if (fp == NULL){
        fclose(fp);
        fp = fopen("list.txt", "w");
    }
    fclose(fp);

    // visualizzo le eventuali materie
    printf("\nElenco materie:\n");
    fp = fopen("list.txt", "r");
    while(fgetc(subject, 22, fp) != NULL){
        printf("- &s \n", subject);
    }
    fclose(fp);

    // append
    fp = open("list.txt", "a");
    do{
        printf("\nInserisci una materia [FINE per concludere]\n>>> ")
        fflush(stdin);  // pulisce il buffer di input
        gets(subject);

        if(strcmp(subject, "FINE") != 0){
            fputs("- ", fp);
            fputs(subject, fp);
        }
    } while (strcmp(subject, "FINE") != 0);


    printf("\n\n");
}
