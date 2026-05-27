# Modulo 1 – Programmazione a Oggetti, Incapsulamento e Introduzione all'UML in C#

## 1. Parte Teorica

### Introduzione alla Programmazione ad Oggetti (OOP) in C#
La programmazione ad oggetti (OOP) organizza il codice attorno a **oggetti**: entità che combinano dati e comportamenti. In C# questo paradigma è fortemente supportato e permette la creazione di codice **modulare**, **manutenibile** e **riutilizzabile**.

**Concetti Chiave:**
- **Classe e Oggetto:**  
  - **Classe:** Modello che definisce attributi (stato) e metodi (comportamenti).  
  - **Oggetto:** Istanza concreta di una classe.
- **Incapsulamento:**  
  - **Obiettivo:** Nascondere i dettagli interni di un oggetto, esponendo solo ciò che è necessario tramite proprietà e metodi pubblici.  
  - **In C#:**  
    - Utilizzo di campi `private` per proteggere lo stato.  
    - Uso di **proprietà** (`get` e `set`) per controllare l’accesso e l’assegnazione dei valori.

### Proprietà e Costruttore in C#
Le **proprietà** in C# offrono una sintassi elegante per il getter/setter e permettono di aggiungere logiche di validazione.

**Esempio – Classe `Persona`:**

```csharp
using System;

namespace EsempioOOP
{
    public class Persona
    {
        // Attributi privati
        private string nome;
        private string cognome;
        private int eta;

        // Costruttore
        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta; // Utilizza la proprietà per applicare il controllo
        }

        // Proprietà per 'Nome'
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Proprietà per 'Cognome'
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        // Proprietà per 'Eta' con validazione
        public int Eta
        {
            get { return eta; }
            set
            {
                if (value > 0)
                    eta = value;
                else
                    Console.WriteLine("Errore: l'età deve essere maggiore di 0.");
            }
        }
    }

    // Classe per testare la classe Persona
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mario", "Rossi", 25);
            Console.WriteLine($"{persona1.Nome} {persona1.Cognome}, Età: {persona1.Eta}");
            
            // Test: tentativo di impostare un'età negativa
            persona1.Eta = -5;  // Verrà visualizzato un messaggio di errore
            Console.WriteLine($"Età corrente: {persona1.Eta}");
            
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
```

### Introduzione a UML

**UML** (Unified Modeling Language) è un linguaggio di modellazione visiva usato per rappresentare graficamente la struttura del software.  
In questo modulo ci concentreremo sul **diagramma delle classi**, il quale mostra:
- Il nome della classe
- Attributi
- Metodi
- La visibilità dei membri (usando:
  - `+` per `public`
  - `-` per `private`)

**Esempio di diagramma UML per la classe `Persona`:**

```
+------------------------------+
|          Persona             |
+------------------------------+
| - nome: string               |
| - cognome: string            |
| - eta: int                   |
+------------------------------+
| +Persona(nome, cognome, eta) |
| +Nome: string {get; set;}    |
| +Cognome: string {get; set;} |
| +Eta: int {get; set;}        |
+------------------------------+
```

---

## 2. Esercizi da Fare in Classe

### Esercizio 1.1 – Creazione della Classe `Persona`
**Obiettivi:**  
- Comprendere la definizione di una classe, la creazione di un oggetto e l’uso di costruttori e proprietà.

**Istruzioni:**
1. Crea un nuovo progetto Console in C# (ad esempio in Visual Studio o Visual Studio Code).
2. Definisci la classe `Persona` con gli attributi `nome`, `cognome` e `eta` come campi **private**.
3. Implementa le proprietà `Nome`, `Cognome` e `Eta` (il setter di `Eta` deve accettare solo valori maggiori di 0).
4. Aggiungi un costruttore che accetta tre parametri.
5. Nel metodo `Main()`, crea almeno due istanze della classe `Persona` e stampa i dati.
6. Verifica il funzionamento inserendo un’età negativa per testare la validazione.

---

### Esercizio 1.2 – Disegnare il Diagramma UML di `Persona`
**Obiettivo:**  
- Imparare a rappresentare la struttura di una classe con un diagramma UML.

**Istruzioni:**
- Una volta completata la classe `Persona`, disegna il relativo diagramma UML (su carta o utilizzando strumenti online come Lucidchart, draw.io o yUML).
- Il diagramma dovrà includere:
  - I campi **private** (con segno “–”).
  - Le proprietà **public** (con segno “+”).
  - Il costruttore.

---

### Esercizio 1.3 – Modifica dei Dati Tramite Proprietà
**Obiettivo:**  
- Verificare il corretto funzionamento dei metodi getter e setter.

**Istruzioni:**
1. Dopo aver creato un oggetto della classe `Persona`, modifica il valore delle proprietà `Nome` e `Eta`.
2. Prova ad assegnare un’età negativa e osserva che il sistema gestisce correttamente l’errore.
3. Stampa i dati aggiornati per verificare che le modifiche siano state applicate (o bloccate nel caso di errori).

---

## 3. Esercizi di Approfondimento (da Svolgere a Casa)

### Esercizio A – Aggiungi la Proprietà `Indirizzo`
**Obiettivo:**  
Approfondire l’incapsulamento aggiungendo un nuovo attributo.

**Istruzioni:**
1. Estendi la classe `Persona` aggiungendo il campo privato `indirizzo`.
2. Implementa la proprietà `Indirizzo` con i metodi getter e setter, includendo nel setter un controllo che impedisca l’assegnazione di stringhe vuote o `null`.
3. Disegna il nuovo diagramma UML aggiornato con il campo `indirizzo`.

---

### Esercizio B – Creazione della Classe `ContoBancario`
**Obiettivo:**  
Applicare i concetti di incapsulamento alla definizione di una nuova classe.

**Istruzioni:**
1. Crea la classe `ContoBancario` con i seguenti attributi privati:  
   - `numeroConto` (string)  
   - `saldo` (double)
2. Implementa un costruttore che accetti il numero di conto e il saldo iniziale (il saldo deve essere maggiore o uguale a 0).
3. Definisci proprietà per `NumeroConto` e `Saldo` (il setter per `Saldo` deve impedire valori negativi).
4. Aggiungi due metodi:  
   - `Deposita(double importo)`: che aggiunge l'importo al saldo.  
   - `Preleva(double importo)`: che sottrae l'importo solo se il saldo residuo rimane non negativo; altrimenti segnala un errore.
5. Disegna il diagramma UML per la classe `ContoBancario`.

---

### Esercizio C – Refactoring e Aggiornamento UML della Classe `Persona`
**Obiettivo:**  
Stimolare il pensiero critico sul codice e migliorare le capacità di refactoring.

**Istruzioni:**
1. Rivedi la classe `Persona` creata in classe.
2. Identifica almeno due possibili miglioramenti (ad esempio: gestione di input null, l'uso di eccezioni per errori critici al posto dei messaggi in console, miglioramenti nei commenti).
3. Riscrivi la classe applicando le modifiche identificate.
4. Scrivi un breve documento che descriva:
   - Le migliorie apportate.
   - Il motivo per cui queste modifiche rendono la classe più robusta e manutenibile.
5. Aggiorna il diagramma UML della classe `Persona` per riflettere le modifiche.

---

## UML – Diagramma delle Classi:
- **Simboli:**  
  - `+` = public  
  - `-` = private
- **Esempio – Classe Persona:**
  ```
  +------------------------------+
  |          Persona             |
  +------------------------------+
  | - nome: string               |
  | - cognome: string            |
  | - eta: int                   |
  +------------------------------+
  | +Persona(nome, cognome, eta) |
  | +Nome: string {get; set;}    |
  | +Cognome: string {get; set;} |
  | +Eta: int {get; set;}        |
  +------------------------------+
  ```

## Attività:
1. **In Classe:**
   - Crea la classe `Persona` in C#
   - Disegna il diagramma UML di `Persona`
   - Esegui test con getter/setter e validazioni
2. **A Casa:**
   - Estendi `Persona` con la proprietà `Indirizzo`
   - Crea la classe `ContoBancario`
   - Effettua refactoring a `Persona` e aggiorna l’UML

---

*Obiettivo:* Comprendere i principi base di OOP e UML per prepararsi alle fasi successive del corso.


---

## Conclusioni

Questo modulo unisce la programmazione ad oggetti in C# con l'introduzione a UML. Competenze da acquisire:
- Una solida base teorica su classi, oggetti e incapsulamento.
- Esperienza pratica tramite esercizi in classe.
- Un primo approccio all'UML per visualizzare e documentare il loro codice.
- Opportunità di approfondimento con esercizi da svolgere a casa per consolidare le competenze.
