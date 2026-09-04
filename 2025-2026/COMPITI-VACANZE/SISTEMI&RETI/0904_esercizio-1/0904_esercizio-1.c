// Scrivere un programma in cui, ricevuti in input due numeri ed un carattere dell'insieme ('+', '-', '*', '/'), esegua l'operazione richiesta.

#include <stdio.h>

int main(void)
{
    float num1;
    float num2;
    char op;

    printf("Inserire il primo numero: ");
    scanf("%f", &num1);
    printf("Inserire il secondo numero: ");
    scanf("%f", &num2);

    printf("Inserisci l'operazione (+, -, *, /): ");
    scanf(" %c", &op);
    while (op != '+' && op != '-' && op != '/' && op != '*')
    {
        printf("Carattere non valido! Reinserire: ");
        scanf(" %c", &op);
    }

    if (op == '/' && num2 == 0)
    {
        printf("Errore: divisione per zero.\n");
        return 1;
    }

    switch (op)
    {
        case '+':
            printf("Risultato: %f\n", num1 + num2);
            break;
        case '-':
            printf("Risultato: %f\n", num1 - num2);
            break;
        case '*':
            printf("Risultato: %f\n", num1 * num2);
            break;
        case '/':
            printf("Risultato: %f\n", num1 / num2);
            break;
    }

    return 0;
}