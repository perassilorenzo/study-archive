int num = 5;
int num2 = 4;

int f1(num, num2){
    int r = (num * num) + num2;
    return r;
}

int f2(a, b){
    int r = a % b;
    return r;
}

int f3(a, b){
    int r;
    if(a > b)
        r = a - b;
    else
        r = a + b;
    return r;
}

int main(){
    int n1 = 2;
    int n2 = 7;
    int ris1 = f1(num);
    int ris2 = f2(ris1,n1);
    int ris3 = f3(ris2,n2);
    printf("%d\n",ris3);
    return 0;
}

/*

RAM
------------------------
STACK:

    // main()
    //     n1 = 2
    //     n2 = 7
    //     ris1 = ? --> f1 = 29
    //     ris2 = 1
    //     ris3 = 8

---------
        
    // f1(num, num2)
    //     num = 5 num2 = 4
    //     r = 25 + 4

---------

    // f2(a, b)
    //     a = 29
    //     b = 2
    //     r = 1

---------

    // f3(a, b)
    //     a = 1
    //     b = 7
    //     r = 8

------------------------
HEAP: //////////////////   
------------------------
DATA:
    num = 5
    num2 = 4

------------------------
CODICE:  
    main()
    f1()
    f2()
    f3()
    printf()

------------------------

*/