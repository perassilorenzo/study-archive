#include <stdio.h>
 int main(){
     int lati;

 printf("inserisci i lati: ");
 scanf("%d",&lati);

 if(lati>=3 && lati<=6){
    switch(lati){
case 3:
    printf("triangolo");
    break;
case 4:
    printf("quadrato");
    break;
case 5:
    printf("pentagono");
    break;
case 6:
    printf("esagono");
    break;
    }
 }
 else
    printf("input errato");
 return 0;
 }