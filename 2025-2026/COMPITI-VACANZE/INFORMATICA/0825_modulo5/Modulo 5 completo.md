# Modulo 5 – Strutture Dati in C#: List, Dictionary, Queue e Stack (C#)

---

## 1. Parte Teorica

### 1.1 List<T>
- **Descrizione:**  
  Collezione dinamica che memorizza elementi dello stesso tipo.
- **Operazioni principali:**  
  `Add`, `Remove`, `Find`, `Sort`.
- **Esempio in C#:**
  ```csharp
  List<string> nomi = new List<string>();
  nomi.Add("Anna");
  nomi.Add("Luca");
  ```

### 1.2 Dictionary<TKey, TValue>
- **Descrizione:**  
  Collezione associativa basata su coppie chiave-valore.
- **Operazioni principali:**  
  `Add`, `TryGetValue`, `Remove`.
- **Esempio in C#:**
  ```csharp
  Dictionary<int, string> rubrica = new Dictionary<int, string>();
  rubrica.Add(1, "Mario Rossi");
  ```

### 1.3 Queue<T>
- **Descrizione:**  
  Struttura FIFO (First In, First Out).
- **Operazioni principali:**  
  `Enqueue`, `Dequeue`, `Peek`.
- **Esempio in C#:**
  ```csharp
  Queue<string> coda = new Queue<string>();
  coda.Enqueue("Primo");
  string prossimo = coda.Dequeue();
  ```

### 1.4 Stack<T>
- **Descrizione:**  
  Struttura LIFO (Last In, First Out).
- **Operazioni principali:**  
  `Push`, `Pop`, `Peek`.
- **Esempio in C#:**
  ```csharp
  Stack<string> pila = new Stack<string>();
  pila.Push("Operazione1");
  string ultimo = pila.Pop();
  ```

### 1.5 UML
È utile rappresentare graficamente le strutture dati per visualizzare i loro membri e operazioni fondamentali.

**Diagramma UML per una classe che utilizza List (es. `GestioneStudenti`):**

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

**Diagramma UML per una Rubrica basata su Dictionary:**

```
+---------------------------------+
|           Rubrica               |
+---------------------------------+
| - studenti: Dictionary<int, Studente> {static} |
+---------------------------------+
| +Aggiungi(id: int, s: Studente): void |
| +Cerca(id: int): Studente         |
| +Rimuovi(id: int): void           |
+---------------------------------+
```

---

## 2. Esercizi da Fare in Classe

### Esercizio 5.1 – Gestione di una Lista
**Obiettivi:**  
- Utilizzare `List<T>` per memorizzare e manipolare dati.

**Istruzioni:**
1. Crea la classe `Studente` con attributi: `Nome`, `Cognome`, `Età`.
2. Crea una `List<Studente>` e aggiungi almeno 5 studenti.
3. Rimuovi un record usando `Remove` o `RemoveAt`.
4. Usa `Find` per cercare uno studente per nome e stampa le informazioni.

### Esercizio 5.2 – Uso di Dictionary per una Rubrica
**Obiettivi:**  
- Gestire dati associativi con `Dictionary<TKey, TValue>`.

**Istruzioni:**
1. Utilizza la classe `Studente`.
2. Crea un `Dictionary<int, Studente>` dove l'ID è la chiave.
3. Aggiungi almeno 3 record.
4. Usa `TryGetValue` per cercare uno studente per ID e stampa i dati.
5. Rimuovi un record con `Remove` e conferma l’operazione.

### Esercizio 5.3 – Simulazione di Queue e Stack
**Obiettivi:**  
- Comprendere le operazioni FIFO e LIFO.

**Istruzioni:**
1. **Per Queue:**  
   - Crea una `Queue<string>` che simuli una coda di stampe.
   - Usa `Enqueue` per inserire 4 messaggi.
   - Usa `Dequeue` e `Peek` per mostrare i messaggi.
2. **Per Stack:**  
   - Crea una `Stack<string>` per registrare operazioni (es. "Aggiungi", "Modifica", "Elimina").
   - Usa `Push`, `Pop` e `Peek` per verificare il comportamento.

---

## 3. Esercizi di Approfondimento (a Casa)

### Esercizio A – Applicazione Integrata
**Obiettivo:**  
- Integrare List, Dictionary, Queue e Stack in un'unica applicazione.

**Istruzioni:**
1. Crea un'app Console per simulare una “rubrica studenti”:
   - Usa una `List<Studente>` per archiviare tutti gli studenti.
   - Usa un `Dictionary<int, Studente>` per l’accesso rapido per ID.
   - Usa una `Queue<string>` per gestire una lista d'attesa.
   - Usa una `Stack<string>` per registrare le operazioni di cancellazione (undo).
2. Implementa un menu interattivo con operazioni di aggiunta, rimozione e ricerca.
3. Documenta il flusso principale con commenti.

### Esercizio B – Ordinamento e Filtraggio
**Obiettivo:**  
- Aggiungere funzionalità di ordinamento e filtro alla `List<Studente>`.

**Istruzioni:**
1. Crea una funzione che ordini la lista per cognome (con `Sort` e comparatore personalizzato).
2. Filtra la lista per studenti con età superiore a un certo valore (utilizzando `FindAll`).
3. Stampa i risultati e commenta le operazioni.

### Esercizio C – Manipolazione Avanzata del Dictionary
**Obiettivo:**  
- Sperimentare funzioni avanzate su un Dictionary.

**Istruzioni:**
1. Crea un Dictionary che mappi l’ID di uno studente a un voto (int).
2. Implementa funzioni per:
   - Aggiungere/aggiornare il voto.
   - Calcolare la media.
   - Trovare lo studente con voto massimo.
3. Documenta il codice con commenti che spieghino ciascun metodo.

### 3.5 UML
Per documentare la gestione delle collezioni, disegna i seguenti diagrammi UML:

**Esempio UML per la Gestione Studenti (con List):**

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

**Esempio UML per la Rubrica (Dictionary):**

```
+---------------------------------+
|           Rubrica               |
+---------------------------------+
| - studenti: Dictionary<int, Studente> |
+---------------------------------+
| +Aggiungi(id: int, s: Studente): void |
| +Cerca(id: int): Studente         |
| +Rimuovi(id: int): void           |
+---------------------------------+
```
## Attività:
1. **In Classe:**  
   - Gestire liste di studenti e rubrica.
   - Simulare code (Queue) e pile (Stack).
2. **A Casa:**  
   - Integrare operazioni in un'applicazione di prenotazioni.
   - Implementare funzioni di ordinamento, filtraggio e aggregazione.