// Scrivere  un  programma in  cui, ricevuta  in  input  una  Stringa  S, vengono  raddoppiati i  caratteri corrispondenti alle vocali direttamente sulla Stringa S; infine visualizzare la stringa ottenuta.

#include <stdio.h>
#include <ctype.h>

int main (void){
    char S[100];
    printf("Inserisci la stringa ");
    scanf("%99s", S);

    for (int i = 0; S[i] != '\0'; i++){
        switch (tolower(S[i]))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                for (int j = 98; j > i; j--)
                {
                    S[j] = S[j - 1];
                }

                S[i + 1] = S[i];
                i++;
                break;
        }
    }

    for (int i = 0; S[i] != '\0'; i++){
        printf("%c", S[i]);
    }

    return 0;
}