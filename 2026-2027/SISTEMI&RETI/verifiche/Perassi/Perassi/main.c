#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// prototipi

void Punto1();
void Punto2();
void Punto3();
void Punto4();
void Punto5();
void Punto6();

int main()
{
    char nomeFile[30+1];
    char ipCliente[20+1];
    long nByte;
    int tempo;

    int exit = 0;

    do{
        printf("\nCosa vuoi fare? [1-7]\n>>> ");
        int choice = 0;
        scanf("%i", &choice);

        switch(choice){
            case 1:
                Punto1();
                break;

            case 2:
                Punto2();
                break;

            case 3:
                Punto3();
                break;

            case 4:
                Punto4();
                break;

            case 5:
                Punto5();
                break;

            case 6:
                Punto6();
                break;

            case 7:
                exit = 1;
                break;
        }
    } while(exit == 0);

    return 0;
}

void Punto1(){
    ModifyFile("provider1.txt");
}

void Punto2(){
    ModifyFile("provider2.txt");
}

void Punto3(){
    VisualFile("provider1.txt");
}

void Punto4(){
    VisualFile("provider2.txt");
}

void Punto5(){
    char ip[20+1];
    printf("\nInserisci l'indirizzo IP [XXX.XXX.XXX.XXX] >>> ");
    scanf("%s", ip);

    FILE *fp;
    fp = fopen("riepilogo.txt", "w");
    if (fp == NULL)
        return;

    fflush(fp);

    RicercaIP(ip, "provider1.txt");
    RicercaIP(ip, "provider2.txt");

    fclose(fp);
}

void RicercaIP(char IP[20+1], char fileName[30+1]){
    FILE *fp;
    fp = fopen(fileName, "r");
    if (fp == NULL){
        printf("\nFile inesistente\n");
        return;
        fclose(fp);
    }

    char nf[30+1], ip[20+1];
    long nb;
    int t;

    fprintf(fp, "\Nome File\IP\t\Numero Byte\t\Tempo");

    while(!feof(fp)) {
        fscanf(fp, "%s %s %l %i", nf, ip, &nb, &t);
        if (strcmp(IP, ip) == 0)
            printf("\n%s\t\t%s\t\t%l\t\t%i", nf, ip, nb, t);
    }

    fclose(fp);

}

void Punto6(){
    FILE *fp;
    fp = fopen("riepilogo.txt", "r");
    if (fp == NULL){
        fclose(fp);
        fp = fopen("riepilogo.txt", "w");
        printf("File creato con successo, richiedi di nuovo");
        fclose(fp);
        return;
    }

    VisualRecap();


}

void VisualRecap(){
    FILE *fp;
    fp = fopen("riepilogo.txt", "w");
    if (fp == NULL)
        return;

    char nf[30+1], ip[20+1];
    long nb;
    int t;

    fprintf(fp, "\Nome File\IP\t\Numero Byte\t\Tempo");

    while(!feof(fp)) {
        fscanf(fp, "%s %s %l %i", nf, ip, &nb, &t);
        printf("\n%l\t\t%i", nb, t);

        if (nb > 5)
            printf("\n\n !!! I BYTE TRASFERITI SUPERANO IL LIMITE !!!");
    }

    fclose(fp);



}

void ModifyFile(char fileName[30+1]){
    FILE *fp;
    fp = fopen(fileName, "w");
    if (fp == NULL){
        fclose(fp);
        return;
    }

    char nf[30+1], ip[20+1];
    long nb;
    int t;

    char c;

    do
    {

        printf("\nInserimento dati\n\n");

        printf("\nInserisci nome file >>> ");
        fflush(stdin);
        scanf("%s", nf);

        printf("\nInserisci IP cliente >>> ");
        fflush(stdin);
        scanf("%s", ip);

        printf("\nInserisci numero di byte >>> ");
        fflush(stdin);
        scanf("%l", nb);

        printf("\nInserisci tempo impiegato >>> ");
        fflush(stdin);
        scanf("%i", t);

        fprintf(fileName, "%s %s %l %i\n", nf, ip, nb, t);

        printf("\nVuoi continuare [y/n] >>> ");
        fflush(stdin);
        scanf("%c", &c);
    }
    while(c == 'Y' || c == 'y');

    fclose(fp);
}

void VisualFile(char fileName[30+1]){
    FILE *fp;
    fp = fopen(fileName, "r");
    if (fp == NULL){
        printf("\nFile inesistente\n");
        return;
        fclose(fp);
    }

    char nf[30+1], ip[20+1];
    long nb;
    int t;

    printf("\nElenco dati\n\n");

    printf("\Nome File\IP\t\Numero Byte\t\Tempo");

    fscanf(fp, "%s %s %l %i", nf, ip, &nb, &t);
    while(!feof(fp)) {
        printf("\n%s\t\t%s\t\t%l\t\t%i", nf, ip, nb, t);
        fscanf(fp, "%s %s %l %i", nf, ip, &nb, &t);
    }

    fclose(fp);





}
