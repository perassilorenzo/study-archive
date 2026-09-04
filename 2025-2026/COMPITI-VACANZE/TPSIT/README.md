# Battaglia navale

Semplice versione del gioco **Battaglia navale**, realizzata con HTML, CSS e JavaScript per il compito delle vacanze di TPSIT.

## Link del progetto

- [Repository GitHub](https://github.com/perassilorenzo/study-archive/tree/main/2025-2026/COMPITI-VACANZE/TPSIT)
- [Gioco pubblicato con GitHub Pages](https://perassilorenzo.github.io/study-archive/2025-2026/COMPITI-VACANZE/TPSIT/index.html)

## Descrizione

Il giocatore deve trovare tutte le navi nascoste facendo clic sulle celle di una griglia. Dopo ogni tentativo viene mostrato visivamente se il colpo è andato a segno oppure se è stata trovata acqua. La partita termina quando tutte le navi sono state colpite.

### Tema scelto

È stato scelto il tema del **mare**, coerente con il gioco della battaglia navale. Sono stati utilizzati colori azzurri e le icone `🎯` per indicare un colpo riuscito e `💦` per indicare l’acqua.

### Dimensione della griglia

La griglia è composta da **64 celle**, organizzate in **8 righe e 8 colonne**.

### Numero e dimensione delle navi

Sono presenti **4 navi**, ognuna formata da **1 cella**. In totale, quindi, le celle occupate dalle navi sono 4.

### Modalità di posizionamento delle navi

Le navi sono definite direttamente nel codice JavaScript, nell’array `naviIniziali`. Sono posizionate verticalmente nella prima colonna, alle coordinate:

- riga 0, colonna 0;
- riga 1, colonna 0;
- riga 2, colonna 0;
- riga 3, colonna 0.

Il posizionamento non è casuale.

### Temporizzazione utilizzata

È stato utilizzato un **cronometro**. Il conteggio parte quando si preme il pulsante `Inizia` e aumenta di un secondo alla volta tramite `setInterval()`. Quando il giocatore trova tutte le navi, il cronometro viene fermato con `clearInterval()`.

## Elementi creati dinamicamente con JavaScript

JavaScript crea dinamicamente tutte le celle della griglia nel DOM quando viene avviata una partita. Per ogni cella viene creato un elemento `div` con la classe `cell` e viene associato l’evento di clic che richiama la funzione `Cell()`.

Inoltre, JavaScript aggiorna dinamicamente:

- il colore della cella colpita o dell’acqua;
- l’icona mostrata nella cella;
- il numero dei tentativi;
- il numero di celle-nave ancora da trovare;
- il tempo trascorso;
- il messaggio finale;
- il pulsante per ricominciare la partita.

## Funzionalità facoltative aggiunte

Sono state aggiunte alcune funzionalità oltre alla versione base:

- possibilità di ricominciare la partita tramite il pulsante `Ricomincia`;
- disattivazione delle celle già cliccate;
- cursore `not-allowed` sulle celle già utilizzate;
- blocco della griglia al termine della partita;
- personalizzazione grafica con colori, icone e stile ispirati al mare;
- visualizzazione del messaggio finale con il numero di tentativi e il tempo impiegato.

Non sono stati aggiunti il posizionamento casuale, navi di lunghezza diversa, livelli di difficoltà o suoni.

## Difficoltà incontrate

Le principali difficoltà sono state:

- creare la griglia dinamicamente invece di scrivere tutte le celle nell’HTML;
- gestire il controllo delle coordinate delle navi tramite array e cicli;
- impedire che la stessa cella venisse cliccata più volte;
- aggiornare correttamente i contatori e il messaggio finale;
- avviare e fermare il cronometro con `setInterval()` e `clearInterval()`;
- applicare le modifiche a tutte le celle della griglia, poiché `getElementsByClassName()` restituisce una collezione di elementi e non una singola cella.

## Struttura dei file

```text
TPSIT/
├── index.html
├── README.md
├── scripts/
│   └── script.js
└── styles/
    └── style.css
```

---

## 🎮 Come giocare

1. Aprire il [gioco online](https://perassilorenzo.github.io/study-archive/2025-2026/COMPITI-VACANZE/TPSIT/index.html).
2. Premere il pulsante **Inizia**.
3. Fare clic sulle celle della griglia per cercare le navi.
4. Osservare i risultati e i contatori aggiornati dopo ogni tentativo.
5. Trovare tutte le navi nel minor numero possibile di tentativi e nel minor tempo possibile.

## 🧭 Regole del gioco

| Elemento | Regola |
| --- | --- |
| Obiettivo | Trovare tutte le 4 celle occupate dalle navi |
| Tentativo | Ogni clic su una cella non ancora utilizzata conta come un tentativo |
| Acqua | La cella diventa azzurra e mostra l’icona `💦` |
| Colpito | La cella diventa rossa e mostra l’icona `🎯` |
| Doppio clic | La stessa cella non può essere selezionata nuovamente |
| Vittoria | La partita termina quando tutte le navi sono state trovate |

## 🛠️ Tecnologie utilizzate

| Tecnologia | Utilizzo |
| --- | --- |
| HTML5 | Struttura della pagina e contenitori dell’interfaccia |
| CSS3 | Colori, griglia, dimensioni, spaziatura e cursori |
| JavaScript | Logica del gioco, eventi e aggiornamento della pagina |
| DOM | Creazione delle celle e modifica dei contenuti visualizzati |
| `setInterval()` | Aggiornamento del cronometro ogni secondo |
| `clearInterval()` | Arresto del cronometro alla fine della partita |

## ⚙️ Funzionamento interno

Il pulsante di avvio richiama la funzione `Grid()`, che svuota la griglia e genera 64 elementi `div` tramite JavaScript. Ogni elemento riceve le coordinate della propria posizione e un evento `onclick`.

Quando il giocatore seleziona una cella, la funzione `Cell()` confronta le coordinate con quelle contenute nell’array delle navi. In base al risultato, la cella viene marcata come acqua o colpita. La classe `clicked` impedisce di conteggiare più volte la stessa posizione.

La partita viene considerata conclusa quando il numero delle navi rimaste raggiunge zero. In quel momento vengono mostrati il messaggio finale e il pulsante per iniziare una nuova partita, mentre il cronometro viene fermato.

## ▶️ Avvio in locale

Non sono necessarie librerie o installazioni aggiuntive. È sufficiente:

1. scaricare o clonare il repository;
2. aprire la cartella `TPSIT`;
3. aprire `index.html` in un browser;
4. premere **Inizia**.

## 📁 Risorse del progetto

- [Pagina HTML](index.html)
- [Codice JavaScript](scripts/script.js)
- [Foglio di stile CSS](styles/style.css)
- [Cartella delle risorse](assets/)

## 📌 Stato del progetto

**Completato:** il gioco è funzionante, pubblicato su GitHub Pages e pronto per essere utilizzato dal browser.

## 👤 Autore

**Lorenzo Perassi**

- [Profilo GitHub](https://github.com/perassilorenzo)

---

<p align="center">Made with ❤️ by <strong>Lorenzo Perassi</strong></p>
