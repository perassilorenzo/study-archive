# Modulo 7 – Preverifica e Verifica Finale (C#)

---

## 1. Parte Teorica – Revisione dei Concetti Fondamentali

### 1.1 Riepilogo della Programmazione ad Oggetti (OOP)
- **Classi e Oggetti:**  
  Le classi sono modelli che definiscono attributi e metodi; gli oggetti sono istanze concrete di tali classi.
  
- **Incapsulamento:**  
  Nascondere i dati interni della classe tramite campi privati ed esporli in modo controllato tramite proprietà (getters e setters).  
  *Esempio:*  
  ```csharp
  private int eta;
  public int Eta
  {
      get { return eta; }
      set { if(value > 0) eta = value; }
  }
  ```

- **Costruttori:**  
  Metodi speciali per inizializzare le nuove istanze.
  
- **Overload dei Metodi:**  
  Permette di definire metodi con lo stesso nome ma firme diverse, adattando il comportamento in base ai parametri forniti.

### 1.2 Revisione dei Pattern Avanzati
- **Classi Non Istanziabili e Metodi Factory:**  
  Impegnano l'uso di costruttori privati per forzare la creazione degli oggetti tramite metodi statici.  
  *Esempio:*  
  ```csharp
  public class Contatore
  {
      private int valore;
      private Contatore() { valore = 0; }
      public static Contatore CreaContatore() { return new Contatore(); }
      public void Incrementa() { valore++; }
      public int Valore { get { return valore; } }
  }
  ```

- **Pattern Singleton:**  
  Garantisce che una classe abbia una sola istanza, utilizzando un costruttore privato, un campo statico e un metodo o proprietà per l'accesso.
  *Esempio:*  
  ```csharp
  public class Logger
  {
      private static Logger _istanza;
      private static readonly object _lock = new object();
      private Logger() { }
      public static Logger Instance
      {
          get
          {
              if(_istanza == null)
              {
                  lock(_lock)
                  {
                      if(_istanza == null)
                          _istanza = new Logger();
                  }
              }
              return _istanza;
          }
      }
      public void Log(string messaggio)
      {
          Console.WriteLine("LOG: " + messaggio);
      }
  }
  ```

### 1.3 Revisione delle Strutture Dati
- **List<T>:**  
  Collezione dinamica che permette di aggiungere, rimuovere e cercare elementi.
- **Dictionary<TKey, TValue>:**  
  Struttura dati per associare chiavi a valori, utile per ricerche rapide.
- **Queue<T>:**  
  Gestisce i dati in modalità FIFO (First-In, First-Out).
- **Stack<T>:**  
  Gestisce i dati in modalità LIFO (Last-In, First-Out).

### 1.4 Revisione UML
I diagrammi UML sono strumenti visivi per rappresentare:
- La struttura delle classi (attributi, metodi, modificatori di accesso).
- Le relazioni (che, in questo modulo, si concentrano su singole classi e collezioni senza concetti complessi come l’ereditarietà).

*Esempio UML per una classe di gestione studenti:*
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

---

## 2. Esercizi da Fare in Classe

### Esercizio 7.1 – Test di Conoscenza Teorica
**Obiettivi:**  
- Verificare la comprensione dei concetti chiave trattati (OOP, incapsulamento, costruttori, overload, pattern Singleton, gestione delle collezioni).

**Istruzioni:**
- Preparate, in gruppo, un test scritto (domande a risposta multipla e breve per un totale di 30 domande) che includa domande quali:
  - Definisci incapsulamento e spiega perché è utile.
  - Qual è la differenza tra un membro statico e uno di istanza?
  - Spiega il pattern Singleton e descrivi un esempio di utilizzo.

### Esercizio 7.2 – Revisione Pratica a Laboratorio
**Obiettivi:**  
- Mettere in pratica quanto appreso sviluppando brevi esercizi o codici dimostrativi.

**Istruzioni:**
- In gruppi:
  1. Modificare la classe `Contatore` per includere una funzionalità di reset e aggiornare il relativo diagramma UML.
  2. Implementare un breve programma che utilizzi il `Logger` singleton per loggare eventi in sequenza.
  3. Creare una breve applicazione che combini l’uso di `List` e `Dictionary` per gestire una rubrica, ripassando operazioni di aggiunta, rimozione e ricerca.

---

## 3. Esercizi di Approfondimento (da Svolgere a Casa)

### Esercizio A – Progetto Finale: Sistema di Gestione Studenti
**Obiettivo:**  
- Applicare integralmente i concetti appresi in un progetto che integri OOP, UML, pattern e strutture dati.

**Istruzioni:**
1. Crea un’applicazione Console che gestisca una rubrica studenti, integrando:
   - Una classe `Studente` con attributi e metodi di validazione.
   - Gestione degli studenti tramite una `List<Studente>` e un `Dictionary<int, Studente>`.
   - Funzionalità per aggiungere, rimuovere, cercare e modificare i record.
2. Progetta il diagramma UML dell’applicazione, evidenziando le relazioni e le operazioni.
3. Documenta il codice con commenti esplicativi e scrivi un breve resoconto (max 1 pagina) in cui riassumi il funzionamento del sistema.
---
### Esercizio B – Domande di Approfondimento Teorico
**Obiettivo:**  
- Consolidare i concetti teorici con domande aperte.

**Istruzioni:**
1. Rispondi in forma scritta a domande quali:
   - Quali sono i vantaggi nell’utilizzo dei metodi factory rispetto all’uso diretto del costruttore?
   - Descrivi come il pattern Singleton può semplificare la gestione delle risorse in un’applicazione.
   - Spiega come scegliere tra l’uso di una List e un Dictionary in base al contesto applicativo.

**Scambiatevi le domande tra i vari membri del gruppo**
