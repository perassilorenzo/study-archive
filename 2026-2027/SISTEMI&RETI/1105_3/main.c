#include <stdio.h>

void quadrato(int *num, int *den);

int main() {
    int numeratore, denominatore;
    
    printf("Inserisci il numeratore: ");
    fflush(stdin);
    scanf("%d", &numeratore);
    
    printf("Inserisci il denominatore: ");
    fflush(stdin);
    scanf("%d", &denominatore);
    
    quadrato(&numeratore, &denominatore);
    
    printf("\nFrazione elevata al quadrato: %d/%d", numeratore, denominatore);
    
    return 0;
}
void quadrato(int *num, int *den) {
    *num = (*num) * (*num);
    *den = (*den) * (*den);
}