# include <stdio.h>
# include <math.h>

int main(){

    int a,b,c,delta,x1,x2;

    do

        printf("Inserisci primo numero");
        scanf("%d", &a);

    while (a==0);

    printf("Inserisci secondo numero");
    scanf("%d", &b);
    printf("Inserisci terzo numero");
    scanf("%d", &c);

    delta=b*b - (4*a*c);
    if(delta<0){
        printf("Impossibile");
    }
    else {
            x1= (-b + sqrt(delta))/(2*a);
            x2= (-b - sqrt(delta))/(2*a);
            if(x1==x2){
                printf("Una sola soluzione: %f", x1);
            }
            else {
            printf("Due soluzioni: %f %f",x1, x2);
        }
}
return 0;
}