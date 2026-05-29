## Gestione del tempo e delle date in JavaScript

---

## Oggetto Date

`Date` è un oggetto nativo di JavaScript che rappresenta un preciso istante temporale (data e ora).

Quando viene creato con:

let dateStart = new Date();

viene salvata la data e ora corrente del sistema nel momento dell’esecuzione.

Internamente, una data è rappresentata come un numero (timestamp), cioè i millisecondi trascorsi dal 1 gennaio 1970 (Unix Epoch).

---

## Differenza tra due date

Quando si sottraggono due oggetti `Date`:

let diff = dateEnd - dateStart;

JavaScript converte automaticamente le date in numeri (millisecondi) e calcola la differenza.

Il risultato è:
- un valore numerico in millisecondi
- rappresenta il tempo trascorso tra due momenti

---

## Estrazione delle componenti della data

Da un oggetto Date è possibile estrarre singole parti:

- getDate() → giorno del mese (1–31)  
- getMonth() → mese (0–11)  
- getFullYear() → anno completo  
- getHours() → ore (0–23)  
- getMinutes() → minuti (0–59)  
- getSeconds() → secondi (0–59)  

---

## Mese in JavaScript

Il valore restituito da getMonth() parte da 0:

- 0 = gennaio  
- 1 = febbraio  
- ...  
- 11 = dicembre  

Questo è importante perché spesso va corretto aggiungendo +1 nella visualizzazione.

---

## Timestamp

Ogni oggetto Date può essere rappresentato come timestamp.

Il timestamp è:
- un numero intero
- rappresenta i millisecondi dal 1 gennaio 1970
- usato per confronti e calcoli temporali