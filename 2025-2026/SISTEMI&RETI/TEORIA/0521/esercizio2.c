    int num = 3;

    int f1(){
        int n, somma = 0;
        scanf("%d", &n);
        for (int i = 1; i <= n; i++){
            somma += i;
        }

        return somma;
    }

    int main(){
        int ris = f1();
        int ris2 = ris + num;
        printf("%d\n", ris2);
        return 0;
    }

/*

RAM
------------------------
STACK:

    // main()
    //     ris = ? --> f1() = 0
    //     ris2 = ris + 3

----

    // f1()
    //     n = scanf
    //     somma = 0 + ... + n
    //     i = 1 -> ... -> n-1

------------------------
HEAP: //////////////////   
------------------------
DATA:
    num = 3

------------------------
CODICE:
    main()
    f1()
    scanf()
    printf()

------------------------

*/