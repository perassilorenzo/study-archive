/*
|===================================================================================================|
|                                       		                                            |
|                              	     Libreria FUNZIONI                                              |
|                               	                                                            |
|                              		    Ver. 1.3                                                |
|                                                          		                            |
|                                 Ult.Agg. 19 Marzo 2012                	                    |
|                                                                               	            |
|  Elenco funzioni:                                                                     	    |
|                                                                                           	    |			
|  - clrscr():             	pulisce lo schermo di lavoro;                                       |
|  - gotoxy(x,y):          	posiziona il cursore in una specifica posizione sullo schermo;      |
|  - randomize():          	inizializza la casualità;                                           |
|  - random(numero):       	genera un numero casuale commpreso tra 0 e il numero inserito;      |
|  - textcolor(Colore):    	modifica colore del testo;                                          |
|  - dalay(MilliSecondi):  	crea un attesa in secondi;                                          |
|  - textbackground(Colore):	imposta il colore dello sfondo; 				    |
|  - bubble(int*,int);     ordina il vettore con il metodo Bubble Sort                              |
|                                                                                         	    |
|===================================================================================================|
*/

#include <time.h>
#include <windows.h>


void clrscr()
    {
     system("cls");
    }


int gotoxy(short X, short Y)
    {
	 HANDLE hStdout;
	 CONSOLE_SCREEN_BUFFER_INFO csbiInfo;
	 hStdout = GetStdHandle(STD_OUTPUT_HANDLE);
	 if (! GetConsoleScreenBufferInfo(hStdout, &csbiInfo))
	    {
		 MessageBox(NULL, "GetConsoleScreenBufferInfo", "Console Error", MB_OK);
		 return 1;
	    }
	 csbiInfo.dwCursorPosition.X = X;
	 csbiInfo.dwCursorPosition.Y = Y;
	 if (! SetConsoleCursorPosition(hStdout, csbiInfo.dwCursorPosition))
	    {
		 MessageBox(NULL, "SetConsoleCursorPosition", "Console Error", MB_OK);
		 return 1;
        }
     return 0;
    }


void randomize()
    {
     srand(time(NULL));
    }


int random(int NumMax)
{
    int NumGenerato;

    NumGenerato = rand() % NumMax;
    return NumGenerato;
}


void textcolor(unsigned short color)
    {
     HANDLE hCon = GetStdHandle(STD_OUTPUT_HANDLE);
     SetConsoleTextAttribute(hCon,color);
    }


void delay( int MilliSecondi)
    {
     double Secondi = 0;
     if (MilliSecondi > 0)
        Secondi = MilliSecondi / 1000.0;
     clock_t endwait;
     endwait = clock () + Secondi * CLOCKS_PER_SEC;
     while (clock() < endwait)
           {}
    }


void textbackground(unsigned short color)
    {
     WORD wColor = (color & 0x0F) << 4;
     HANDLE hCon = GetStdHandle(STD_OUTPUT_HANDLE);
     SetConsoleTextAttribute(hCon,wColor);
    }

void bubble(int*vect,int lunghezza)
  {
    int n;
    int scambio;
    int i;
    int aus;

    n = lunghezza-1;

    do
      {
       scambio = 0;
       for (i=0;i<n;i++)
           {
            if (vect[i]>vect[i+1])
               {
                aus = vect[i];
                vect[i] = vect[i+1];
                vect[i+1] = aus;
                scambio = 1;
               }
           }
       n--;
      }
    while(scambio == 1);

  }
