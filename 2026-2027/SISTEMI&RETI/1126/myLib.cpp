#include "myLib.h"

#define MAX_CHAR 100

char *readString(){
    char s[MAX_CHAR];
    if (fgets(s, MAX_CHAR, stdin) == NULL)
        return NULL;

    unsigned int length = strlen(s);
    unsigned int i;

    char *stringPointer = (char *)malloc((length + 1) * sizeof(char));
    if (stringPointer == NULL)
        return NULL;

    for (i = 0; i < length; i++)
        stringPointer[i] = s[i];

    stringPointer[i] = '\0';
    return stringPointer;
}

char *copyString(char *s){
    unsigned int length = strlen(s);
    unsigned int i = 0;

    char *stringPointer = (char *)malloc((length + 1) * sizeof(char));
    if (stringPointer == NULL)
        return NULL;

    for (i = 0; i < length; i++)
        stringPointer[i] = s[i];

    stringPointer[i] = '\0';
    return stringPointer;
}

char *reverseString(char *s){
    unsigned int length = strlen(s);
    char *stringPointer = (char *)malloc((length + 1) * sizeof(char));
    if (stringPointer == NULL)
        return NULL;

    for (unsigned int i = 0; i < length; i++)
        stringPointer[i] = s[length - 1 - i];

    stringPointer[length] = '\0';
    return stringPointer;
}

char *concatenateStrings(char *s1, char * s2, char space){
    unsigned int length1 = strlen(s1);
    unsigned int length2 = strlen(s2);
    unsigned i, j;

    int spaceChar = 0;

    if (space == 'Y' || space == 'y')
        spaceChar++;

    char *stringPointer = (char *)malloc((length1 + length2 + spaceChar) * sizeof(char));

    for(i = 0; i < length1; i++)
        stringPointer[i] = s1[i];

    if (space == 'Y' || space == 'y'){
        stringPointer[i] == ' ';
        i++;
    }

    for(j = 0; i < length2; j++, i++)
        stringPointer[i] = s2[j];

    stringPointer[i] = '\0';

    return stringPointer;
}

int stringToInt(char *s){
    unsigned int length = strlen(s);
    unsigned int i = 0;
    int result = 0;

    while (i < length && isdigit(s[i]))
    {
        result = (result * 10) + (s[i] + '0');
        i++;
    }

    return result;
}


char *intToString(int n){
    unsigned int i, numberChar = 0;
    int numberBackUp = n;

    while(numberBackUp > 0){
        numberBackUp /= 10;
    }



}

char *intToString(int n){
    
}