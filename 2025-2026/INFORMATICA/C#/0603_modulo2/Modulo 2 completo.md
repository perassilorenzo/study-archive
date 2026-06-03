# Modulo 2 – Proprietà, Metodi Get/Set, Gestione dell’Integrità dei Dati e Overload dei Metodi in C#

## 1. Parte Teorica

### Proprietà, Get/Set e Gestione dell’Integrità dei Dati in C#
Le **proprietà** in C# rappresentano un modo elegante per accedere e modificare i campi privati di una classe.  
Utilizzando i metodi getter e setter, possiamo:
- **Controllare i dati in ingresso**: Verificare che i valori rispettino determinate regole (ad esempio, età positiva, prezzo non negativo).
- **Nascondere la logica interna**: Il codice che effettua controlli o trasformazioni rimane incapsulato nel setter o getter, evitando duplicazioni.

**Esempio di Proprietà con Validazione:**

```csharp
public int Eta
{
    get { return eta; }
    set
    {
        // Gestione dell'integrità: l'età deve essere maggiore di 0
        if (value > 0)
            eta = value;
        else
            Console.WriteLine("Errore: l'età deve essere maggiore di 0.");
            // oppure lanciare un'eccezione:
            // throw new ArgumentException("L'età deve essere maggiore di 0.");
    }
}
```

### Overload dei Metodi
L’**overload** dei metodi consente di definire più metodi con lo stesso nome all’interno della stessa classe, purché abbiano firme (tipi e numero dei parametri) diverse.  
Questo approccio:
- Favorisce la leggibilità, permettendo di usare lo stesso nome per operazioni concettualmente simili.
- Adatta il comportamento del metodo in base ai differenti tipi o quantità di parametri in ingresso.

**Esempio di Overload:**

```csharp
public class Calcolatore
{
    // Metodo per sommare due numeri interi
    public int Somma(int a, int b)
    {
        return a + b;
    }
    
    // Overload: Somma due numeri double
    public double Somma(double a, double b)
    {
        return a + b;
    }
    
    // Overload: Somma tre numeri interi
    public int Somma(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

### Integrazione con UML
Anche in questo modulo è utile rappresentare graficamente le classi per evidenziare:
- Le **proprietà** (con relativi tipi e, se presenti, logiche di validazione).
- I **metodi sovraccaricati** (indicando le diverse firme).

**Esempio UML – Classe Calcolatore:**

```
+------------------------------+
|         Calcolatore          |
+------------------------------+
|                              |
+------------------------------+
| +Somma(a: int, b: int): int   |
| +Somma(a: double, b: double): double |
| +Somma(a: int, b: int, c: int): int  |
+------------------------------+
```

---

## 2. Esercizi da Fare in Classe

### Esercizio 2.1 – Estendere la Classe `Persona` con Validazione Avanzata
**Obiettivi:**  
- Rafforzare la gestione dell’integrità dei dati mediante getter e setter.
- Verificare la validazione sui dati inseriti.

**Istruzioni:**
1. A partire dalla classe `Persona` (del Modulo 1), integra una validazione più robusta:
   - Ad esempio, oltre a controllare che l’età sia positiva, puoi verificare che i nomi non siano nulli o stringhe vuote.
2. Aggiorna i setter relativi a `Nome` e `Cognome` per stampare un messaggio di errore se il valore è una stringa vuota o nullo.
3. Esegui dei test nel metodo `Main()`:
   - Crea istanze della classe `Persona` e prova ad assegnare valori non validi.
   - Verifica che i controlli impediscano l’assegnazione di dati non corretti.

### Esercizio 2.2 – Implementare e Testare Overload in una Classe
**Obiettivi:**  
- Comprendere l’utilizzo dell’overload dei metodi.
- Applicare il concetto in una situazione pratica.

**Istruzioni:**
1. Crea una classe `Calcolatore` come nell’esempio teorico.
2. Implementa i seguenti metodi `Somma`:
   - Somma di due interi.
   - Somma di due double.
   - Somma di tre interi.
3. Nel metodo `Main()`, crea un’istanza della classe `Calcolatore` e chiama i metodi `Somma` con differenti tipi e numero di parametri.
4. Visualizza i risultati per verificare che l’overload funzioni correttamente.

---

## 3. Esercizi di Approfondimento (da Svolgere a Casa)

### Esercizio A – Refactoring Avanzato della Classe `Persona`
**Obiettivo:**  
- Migliorare la gestione dell’integrità dei dati.
- Applicare ulteriori controlli nei setter.

**Istruzioni:**
1. Rivedi la classe `Persona` sviluppata in classe e apporta miglioramenti:
   - Ad esempio, lancia eccezioni al posto dei soli messaggi in console per errori critici.
   - Controlla che i nomi non contengano numeri o caratteri speciali indesiderati.
2. Documenta le modifiche apportate in un breve documento (massimo 1 pagina).
3. Aggiorna il diagramma UML della classe `Persona` includendo eventuali nuovi metodi o proprietà.

---

### Esercizio B – Creazione di una Classe `Prodotto` con Overload
**Obiettivo:**  
- Applicare i concetti delle proprietà con validazione e l’overload dei metodi in un contesto applicativo.

**Istruzioni:**
1. Crea la classe `Prodotto` con i seguenti attributi privati:
   - `nome` (string)
   - `prezzo` (double)
2. Implementa le proprietà `Nome` e `Prezzo`:
   - Il setter per `Prezzo` deve impedire l’assegnazione di valori negativi.
3. Aggiungi un costruttore che inizializzi i valori e verifichi le regole di integrità.
4. Implementa due metodi chiamati `AggiornaPrezzo`:
   - Uno che accetta un parametro di tipo `double` e aggiorna direttamente il prezzo.
   - Un overload che accetta il prezzo e una percentuale di sconto, calcolando il nuovo prezzo.
5. Disegna il diagramma UML aggiornato della classe `Prodotto`.

---


## UML – Rappresentazione:
- Evidenzia proprietà e metodi.
- Indica i metodi sovraccaricati con le diverse firme.

## Attività:
1. **In Classe:**
   - Migliorare la classe `Persona` con validazioni avanzate.
   - Creare e testare la classe `Calcolatore` con metodi overload.
2. **A Casa:**
   - Refactoring della classe `Persona` e aggiornamento UML.
   - Creare la classe `Prodotto` con gestione integrità e overload nel metodo `AggiornaPrezzo`.

*Obiettivo:* Approfondire l'uso delle proprietà per proteggere i dati e comprendere come l'overload dei metodi migliori la flessibilità del codice.

---

## Conclusioni

Il Modulo 2 fornisce una solida base per:
- Gestire in modo sicuro e controllato i dati tramite proprietà e validazioni.
- Utilizzare l’overload dei metodi per rendere il codice più flessibile e leggibile.
- Integrare la progettazione orientata agli oggetti con rappresentazioni UML che aiutino a visualizzare e documentare l’architettura del software.
