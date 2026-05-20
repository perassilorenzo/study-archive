#include <stdio.h>

int main() {
    int ns;             // numero scatti
    float costo = 0;

    printf("numero scatti: ");
    scanf("%d", &ns);

    if(ns <= 30){
        costo = ns * 0.20 + 2.50;
    }
    else if(ns <= 100){
        costo = 30 * 0.20 + (ns - 30) * 0.15 + 2.50;
    }
    else {
        costo = 30 * 0.20 + 70 * 0.15 + (ns - 100) * 0.10 + 2.50;
    }

    printf("Il costo della bolletta e': ", costo);

    return 0;
}