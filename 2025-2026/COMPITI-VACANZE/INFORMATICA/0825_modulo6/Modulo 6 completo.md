# Modulo 6 – Gestione di Record nelle Collezioni: Aggiunta, Rimozione e Ricerca di Elementi (C#)

## 1. Parte Teorica

### 1.1 Introduzione
La gestione dei record nelle collezioni è fondamentale per applicazioni reali. Si applicano operazioni come:
- **Aggiunta:** Inserimento di nuovi record.
- **Rimozione:** Eliminazione di record esistenti.
- **Ricerca:** Trovare record basati su criteri specifici.

### 1.2 Operazioni su List<T> e Dictionary<TKey, TValue>
- **List<T>:**
  - Aggiunta con `Add()`
  - Rimozione con `Remove()` o `RemoveAt()`
  - Ricerca con `Find()`/`FindAll()`
- **Dictionary<TKey, TValue>:**
  - Aggiunta con `Add()`
  - Rimozione con `Remove(key)`
  - Ricerca con `TryGetValue()`

### 1.3 UML
Documentare graficamente le operazioni e la struttura delle classi che gestiscono i record.

**Esempio UML per una Classe `GestioneStudenti`:**

```
+----------------------------------+
|        GestioneStudenti          |
+----------------------------------+
| - studenti: List<Studente>        |
+----------------------------------+
| +AggiungiStudente(s: Studente): void |
| +RimuoviStudente(s: Studente): void  |
| +CercaStudente(nome: string): Studente |
+----------------------------------+
```

**Esempio UML per una Rubrica basata su Dictionary:**

```
+----------------------------------+
|             Rubrica              |
+----------------------------------+
| - studenti: Dictionary<int, Studente> |
+----------------------------------+
| +Aggiungi(id: int, s: Studente): void |
| +Cerca(id: int): Studente         |
| +Rimuovi(id: int): void           |
+----------------------------------+
```

---

## 2. Esercizi da Fare in Classe

### Esercizio 6.1 – Gestione di una Lista di Studenti
**Obiettivi:**  
- Gestire una `List<Studente>`: aggiungere, rimuovere, cercare.

**Istruzioni:**
1. Definisci la classe `Studente` con attributi: `Nome`, `Cognome`, `Età`.
2. Crea una `List<Studente>` in un’app Console.
3. Aggiungi almeno 5 record.
4. Rimuovi un record in base a un criterio (nome o indice).
5. Utilizza il metodo `Find` per cercare uno studente e stampa i dati.

### Esercizio 6.2 – Gestione di una Rubrica con Dictionary
**Obiettivi:**  
- Utilizzare un `Dictionary<int, Studente>` per ricerche rapide.

**Istruzioni:**
1. Usa la classe `Studente`.
2. Crea un `Dictionary<int, Studente>` dove l'ID è la chiave.
3. Inserisci almeno 3 record.
4. Esegui una ricerca con `TryGetValue` e mostra i dati.
5. Rimuovi un record tramite `Remove` e stampa un messaggio di conferma.

---

## 3. Esercizi di Approfondimento (a Casa)

### Esercizio A – Applicazione Integrata (Rubrica Studenti)
**Obiettivo:**  
- Creare un'app che gestisca una rubrica con List e Dictionary.

**Istruzioni:**
1. Crea un’app Console che simuli la gestione di una rubrica studenti.
2. Usa:
   - `List<Studente>` per memorizzare l’elenco.
   - `Dictionary<int, Studente>` per l’accesso rapido per ID.
3. Implementa un menu per:
   - Aggiungere un nuovo studente.
   - Rimuovere uno studente.
   - Cercare uno studente.
   - (Opzionale) Modificare un record.
4. Documenta il flusso con commenti.

### Esercizio B – Ordinamento e Filtraggio
**Obiettivo:**  
- Aggiungere funzioni di ordinamento e filtro alla lista degli studenti.

**Istruzioni:**
1. Scrivi una funzione per ordinare la `List<Studente>` per cognome.
2. Filtra la lista per studenti con età superiore a un valore dato (usando `FindAll`).
3. Mostra i risultati ordinati e filtrati in console.

### Esercizio C – Operazioni Avanzate con Dictionary
**Obiettivo:**  
- Implementare operazioni avanzate su un Dictionary che mappa ID a voti.

**Istruzioni:**
1. Crea un Dictionary che mappa ID (int) a voto (int) per studenti.
2. Implementa:
   - Funzione per aggiornare il voto.
   - Funzione per calcolare la media dei voti.
   - Funzione per trovare lo studente con voto massimo.
3. Documenta il codice con commenti.

---

## Attività:
1. **In Classe:**  
   - Gestire una List di studenti ed una Rubrica con Dictionary.
2. **A Casa:**  
   - Creare un'app interattiva per la gestione di una rubrica studenti.
   - Implementare funzioni di ordinamento e aggregazione.

---

## Conclusioni Generali

Questi moduli integrano non solo la programmazione pratica in C# per la gestione di record, collezioni e creazione controllata degli oggetti, ma anche la documentazione UML per visualizzare la struttura e le operazioni fondamentali. Le parti UML aiutano a:

- Chiarire la struttura delle classi e delle collezioni.
- Favorire una migliore comprensione e comunicazione del design del software.