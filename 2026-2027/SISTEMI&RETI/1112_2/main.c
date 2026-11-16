#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{

    char *cogno;
    char *nome;
    
    printf("\nEsercizio 7: allocazione Dinamica per Memorizzare Cognome e Nome");

    cogno = (char *)malloc(8 * sizeof(char));
    strcpy(cogno,"Maggiore");

    nome = (char *)malloc(9 * sizeof(char));
    strcpy(nome,"Giampaolo");

    printf("\n\nCognome: \"%s\" ", cogno);
    printf("\nNome: \"%s\" ", nome);

    printf("\n\n");

    free(cogno);
    free(nome);

    return 0;
}