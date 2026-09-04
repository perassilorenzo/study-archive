// Scrivere  un  programma in  cui, ricevuta  in  input  una  Stringa  S, vengono  cancellati i caratteri corrispondenti alle consonanti direttamente sulla Stringa S; infine visualizzare la stringa ottenuta.

#include <stdio.h>
#include <ctype.h>

int main(void){
    char S[100];
    printf("Inserisci la stringa ");
    scanf("%99s", S);

    for (int i = 0; S[i] != '\0'; i++){
        switch (tolower(S[i]))
        {
            case 'b':
            case 'c':
            case 'd':
            case 'f':
            case 'g':
            case 'h':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
                for (int j = i; j < 99; j++)
                {
                    S[j] = S[j+1];
                }
                break;
        
        }
    }

    for (int i = 0; S[i] != '\0'; i++){
        printf("%c", S[i]);
    }

    return 0;
}