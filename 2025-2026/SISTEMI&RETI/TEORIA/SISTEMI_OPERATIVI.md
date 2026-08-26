# 🖥️ Sistemi Operativi

---

# 📌 Cos'è un Sistema Operativo

Tra i programmi e l'hardware troviamo il **Sistema Operativo (SO)**, che funge da intermediario grazie a delle **interfacce di astrazione**.

Il sistema operativo:

- è un **assegnatore di risorse**, perché distribuisce le risorse hardware tra i vari programmi;
- è un **programma di controllo**, perché verifica la presenza di errori e garantisce il corretto funzionamento del sistema.

---

# ⚙️ Funzioni Principali del Sistema Operativo

1. **Interfaccia con l'utente**
   - **GUI (Graphical User Interface)** → interfaccia grafica dei sistemi moderni
   - **CLI (Command Line Interface)** → interfaccia a riga di comando, molto usata nei sistemi Linux

2. **Esecuzione dei programmi**

3. **Operazioni di I/O**

4. **Gestione del File System**

5. **Comunicazione tra processi**

6. **Rilevamento degli errori**

7. **Allocazione delle risorse**

8. **Protezione e sicurezza**

---

# 🕰️ Evoluzione Storica dei Sistemi Operativi

## 1ª Generazione (1940-1950)

- Non esistevano monitor o tastiere
- Venivano utilizzate le **valvole**
- L'utente inseriva dati tramite **schede perforate**
- La macchina elaborava informazioni in codice binario

---

## 2ª Generazione (1950-1960)

- I computer occupavano intere stanze
- Introduzione dei **transistor** al posto delle valvole
- Presenza di sistemi **batch sequenziali**
- La CPU eseguiva una sola istruzione alla volta
- Programmazione in **Assembly**

---

## 3ª Generazione (1960-1980)

- Introduzione della **multiprogrammazione**
- Nasce il concetto moderno di **Sistema Operativo**
- Maggiore numero di transistor → prestazioni migliori
- I computer iniziano a diventare più accessibili

---

## 4ª Generazione (1980-2000)

- Nasce il **Personal Computer**
- Introduzione del **microprocessore**
- Miglioramento del parallelismo
- Diffusione di sistemi multiutente come:
  - Windows
  - Unix

---

## 5ª Generazione (2010-oggi)

- Focus su:
  - **Intelligenza Artificiale**
  - **Sistemi distribuiti**
  - **Cloud computing**

---

# 🔄 System Calls

## Modalità della CPU

### 1. User Mode
Modalità utilizzata dai programmi utente, con accesso limitato all'hardware.

### 2. Kernel Mode
Modalità privilegiata del sistema operativo.

Il **kernel**:
- comunica con l'hardware;
- gestisce memoria, CPU e dispositivi;
- ha accesso completo alle risorse del sistema.

---

## Cosa sono le System Calls

Le **System Calls** permettono il passaggio dalla **User Mode** alla **Kernel Mode**.

Sono quindi delle interfacce tra:
- programmi utente
- kernel del sistema operativo

---

## API

Le **API (Application Programming Interface)** sono funzioni che internamente utilizzano le system calls.

---

## Funzionamento di una System Call

1. Il programmatore richiama un'API
2. L'API richiama una system call
3. Viene generata una **TRAP** (interrupt software)
4. La CPU passa da User Mode a Kernel Mode
5. Il kernel esegue l'operazione
6. La CPU ritorna in User Mode restituendo il risultato

---

# 🧱 Strutture dei Sistemi Operativi

## 1. Struttura Monolitica

Il kernel contiene tutte le funzionalità del sistema operativo.

### Vantaggi
- semplice da implementare

### Svantaggi
- minore sicurezza
- accesso hardware meno protetto

---

## 2. Struttura Stratificata (Onion Skin)

Il sistema è organizzato in livelli.

| Livello | Funzione |
|---|---|
| 0 | Hardware |
| 1 | Kernel base |
| 2 | Gestione memoria |
| 3 | File System e I/O |
| 4 | Servizi di sistema |
| 5 | Interfaccia utente |
| 6 | Applicazioni |

### Vantaggi
- maggiore sicurezza
- migliore organizzazione

### Svantaggi
- implementazione più complessa
- rallentamenti dovuti al passaggio tra livelli

---

## 3. Struttura Ibrida di Unix

### User Space
- utenti
- compilatori
- librerie di sistema

### Kernel Space
- I/O
- File System
- memoria virtuale
- scheduling CPU

---

## 4. Microkernel

Il kernel contiene solo le funzioni essenziali.

### Kernel
- comunicazione tra processi
- gestione memoria
- scheduling CPU

### User Space
- file system
- driver
- interfacce applicative

### Vantaggi
- maggiore affidabilità
- maggiore modularità

### Svantaggi
- prestazioni inferiori

---

## 5. Struttura di Windows

Sistema ibrido tra:
- monolitico
- microkernel

### User Space
- applicazioni
- API

### Kernel Space

#### Executive
- gestione processi
- memoria virtuale
- file system
- sicurezza

#### Kernel
- scheduling
- interrupt

#### Driver
- gestione dispositivi

---

# 🧠 Gestione della Memoria

Un processo deve essere caricato in RAM.

Per controllare gli spazi assegnati vengono usati:

- **Registro base** → indirizzo iniziale
- **Registro limite** → dimensione massima

Se un processo supera il proprio spazio:
- si verifica un errore di sistema.

---

# 💾 Memoria Virtuale

La memoria virtuale crea l'illusione che ogni processo abbia a disposizione tutta la memoria.

Il sistema usa:
- **indirizzi logici (virtuali)**
- **indirizzi fisici**

La conversione viene effettuata dalla:

- **MMU (Memory Management Unit)**

---

# ⚙️ Fasi di Compilazione di un Programma C

## Esempio

```c
#include <stdio.h>

int x = 5;

int somma(int a, int b) {
    return a + b;
}

int main() {
    int res = somma(x, 3);
    printf("%d\n", res);
    return 0;
}
```

---

## 1. Compilazione

Trasformazione:

```text
Codice C → Assembly → Codice binario
```

### Operazioni svolte

- espansione delle librerie
- creazione della tabella dei simboli

### Tabella dei simboli

| Simbolo | Tipo | Sezione | Offset |
|---|---|---|---|
| x | variabile | DATA | 0x00 |
| somma | funzione | CODICE | 0x10 |
| main | funzione | CODICE | 0x30 |
| printf | funzione | CODICE | 0x25 |

Output:
```text
file.o
```

---

## 2. Linking

Collega:
- file oggetto
- librerie

Output:
```text
file eseguibile
```

### Esempio di indirizzi virtuali

| Sezione | Indirizzo |
|---|---|
| DATA | 0x40000 |
| CODICE | 0x60000 |

### Indirizzi finali

| Simbolo | Indirizzo Virtuale |
|---|---|
| x | 0x40000 |
| somma | 0x60010 |
| main | 0x60030 |
| printf | 0x60025 |

---

## 3. Loading

L'eseguibile viene caricato in memoria RAM.

Il registro **PC (Program Counter)** contiene l'indirizzo della prima istruzione.

---

## 4. Esecuzione

La MMU converte:
- indirizzi logici
- indirizzi fisici

---

# 📦 Segmenti di Memoria di un Processo

```text
--------------------
STACK
--------------------
HEAP
--------------------
DATA
(variabili globali)
--------------------
CODICE
(funzioni)
--------------------
```

---

# 🧩 Allocazione Dinamica

## malloc()

Permette di allocare memoria dinamicamente nell'heap.

```c
int *p = malloc(sizeof(int));
```

### Funzionamento
- viene riservato spazio in memoria
- l'indirizzo viene salvato in un puntatore

---

## free()

Libera la memoria precedentemente allocata.

```c
free(p);
```

Se non viene usata:
- si verificano memory leak.

---

# 🔄 Swapping

Quando la RAM è piena:
- alcuni processi vengono temporaneamente spostati sul disco;
- altri processi con priorità maggiore vengono caricati in RAM.

Questo meccanismo si chiama:

```text
Swapping
```

---

## Thrashing

Se avvengono troppi scambi:
- i processi non riescono ad essere eseguiti;
- le prestazioni calano drasticamente.

Questo fenomeno è chiamato:

```text
Thrashing
```

---

# 📍 Allocazione della Memoria

# 1. Allocazione Contigua

Ogni processo occupa uno spazio continuo in RAM.

## Tecniche

### First Fit
Primo spazio libero disponibile.

### Best Fit
Spazio libero più piccolo possibile.

### Worst Fit
Spazio libero più grande disponibile.

---

## Frammentazione Esterna

Si creano buchi inutilizzati tra i processi.

### Soluzione
- compattazione della memoria

---

## Frammentazione Interna

Parte dello spazio assegnato rimane inutilizzato.

---

# 2. Segmentazione

La memoria è divisa in segmenti.

## Indirizzo logico

```text
<segmento, offset>
```

## Indirizzo fisico

```text
<base, limite>
```

### Vantaggi
- migliore organizzazione
- condivisione segmenti

### Svantaggi
- gestione più complessa

---

# 3. Paginazione

Metodo utilizzato nei sistemi moderni.

## Concetti

- Memoria virtuale → pagine
- RAM → frame

Dimensione tipica:
```text
4 KB
```

---

## Conversione degli indirizzi

### Indirizzo logico
```text
<pagina, offset>
```

### Indirizzo fisico
```text
<frame, offset>
```

---

## Vantaggi
- elimina la frammentazione esterna

## Svantaggi
- frammentazione interna
- gestione delle tabelle delle pagine
- page fault

---

# 🚀 TLB (Translation Lookaside Buffer)

Cache utilizzata per velocizzare la traduzione degli indirizzi.

## TLB HIT
La pagina viene trovata immediatamente.

## TLB MISS
Bisogna consultare la tabella delle pagine.

---

# ⏱️ Tempo Effettivo di Accesso

Esempio:

- Hit Ratio = 80%
- Accesso RAM = 100 ns

Formula semplificata:

```text
Tempo medio =
(hit ratio × tempo hit)
+
(miss ratio × tempo miss)
```

---