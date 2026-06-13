# Modulo 3 – Qualificatori di Visibilità, Costruttori, Membri Statici e Classi Statiche (C#)

## 1. Parte Teorica

### Qualificatori di Visibilità
In C# i **modificatori di accesso** (o qualificatori di visibilità) definiscono la portata dei membri di una classe:
- **public:** Il membro è accessibile da qualsiasi parte.
- **private:** Accessibile solo all’interno della stessa classe.
- **protected:** Accessibile all’interno della classe e delle classi derivate.
- **internal:** Accessibile all’interno dello stesso assembly (progetto).
- **protected internal:** Accessibile da classi nello stesso assembly oppure da classi derivate in altri assembly. (*Molto particolare e raro*)

### Costruttori
Il **costruttore** è un metodo speciale utilizzato per inizializzare un nuovo oggetto.
- **Costruttore di istanza:** Viene chiamato ogni volta che si crea una nuova istanza della classe.
- Utilizza lo stesso nome della classe e non ha un tipo di ritorno.
- Esempio:

```csharp
public class Prodotto
{
    private string nome;
    private double prezzo;

    // Costruttore di istanza
    public Prodotto(string nome, double prezzo)
    {
        this.nome = nome;
        this.prezzo = prezzo;
    }
}
```

### Membri di Classe (Statici) vs Membri di Istanza
- **Membri di istanza:** Ogni oggetto (istanza della classe) ha copie separate dei membri.
- **Membri di classe (statici):** Appartengono alla classe intera e sono condivisi da tutte le istanze.
- Per dichiarare un membro statico in C#, si usa la parola chiave `static`.

Esempio:

```csharp
public class Contatore
{
    // Membro statico: condiviso da tutte le istanze
    public static int TotaleIstanza = 0;

    // Membro di istanza
    public int Conteggio;

    public Contatore()
    {
        // Incrementa il contatore per questa istanza
        Conteggio = 0;
        // Incrementa il totale globale
        TotaleIstanza++;
    }
}
```

### Costruttori Statici
- Un **costruttore statico** viene eseguito una volta sola, prima della prima istanziazione o dell'accesso a membri statici.
- Serve per inizializzare variabili statiche o per eseguire operazioni che devono essere fatte una volta.
- Ha lo stesso nome della classe e utilizza la parola chiave `static`, non può avere parametri.
- Esempio:

```csharp
public class Configurazione
{
    public static string Impostazioni { get; private set; }

    // Costruttore statico
    static Configurazione()
    {
        // Inizializzazione delle impostazioni (può leggere da un file di configurazione, ad esempio)
        Impostazioni = "Configurazione Iniziale";
    }
}
```

### Classi Statiche
- Una **classe statica** non può essere istanziata e contiene solo membri statici.
- Viene utilizzata per raggruppare metodi e proprietà che non dipendono da istanze.
- Si dichiara con la parola chiave `static`.

Esempio:

```csharp
public static class MathUtility
{
    public static int Somma(int a, int b)
    {
        return a + b;
    }

    public static double Media(double a, double b)
    {
        return (a + b) / 2;
    }
}
```

### Integrazione con UML
Nel diagramma UML si possono rappresentare i membri statici sottolineandoli o annotandoli con la parola chiave «static».  
Ad esempio, per una classe `Contatore`:

```
+------------------------------+
|          Contatore           |
+------------------------------+
| - Conteggio: int             |
| - TotaleIstanza: int {static}|
+------------------------------+
| +Contatore()                 |
+------------------------------+
```

---

## 2. Esercizi da Fare in Classe

### Esercizio 3.1 – Creazione di una Classe con Membri di Istanza e Statici
**Obiettivi:**  
- Comprendere la differenza tra membri di istanza e membri statici.
- Utilizzare un costruttore di istanza per aggiornare un membro statico.

**Istruzioni:**
1. Crea una classe `Contatore` come nell’esempio teorico.
2. Dichiarare un membro statico `TotaleIstanza` e un membro di istanza `Conteggio`.
3. Nel costruttore di `Contatore`, inizializza `Conteggio` e incrementa `TotaleIstanza`.
4. Nel metodo `Main()`, crea più istanze di `Contatore` e visualizza il valore del membro statico per verificare il conteggio globale.

### Esercizio 3.2 – Utilizzo di Costruttore Statico e Classe Statica
**Obiettivi:**  
- Creare una classe con costruttore statico per inizializzare variabili statiche.
- Utilizzare una classe statica per raggruppare metodi di utilità.

**Istruzioni:**
1. Crea una classe `Configurazione` che contiene una proprietà statica `Impostazioni` e un costruttore statico per assegnare un valore iniziale.
2. Visualizza il valore di `Impostazioni` nel metodo `Main()` senza creare un’istanza della classe.
3. Crea una classe statica `MathUtility` con alcuni metodi (ad esempio, `Somma` e `Media`).
4. Esegui chiamate ai metodi della classe statica nel metodo `Main()` e stampa i risultati.

---

## 3. Esercizi di Approfondimento (da Svolgere a Casa)

### Esercizio A – Estensione della Classe `Contatore`
**Obiettivo:**  
- Aggiungere funzionalità statiche aggiuntive.
  
**Istruzioni:**
1. Aggiungi alla classe `Contatore` un metodo statico che resetta il valore di `TotaleIstanza`.
2. Documenta il comportamento del metodo e testalo creando e distruggendo istanze (puoi simulare la distruzione tramite azioni nel `Main()`).

### Esercizio B – Creazione di una Classe Utility per la Gestione dei Numeri
**Obiettivo:**  
- Realizzare una classe statica che include più metodi utili.

**Istruzioni:**
1. Crea una classe statica `NumeriUtility` con metodi statici per:
   - Calcolare il quadrato di un numero.
   - Verificare se un numero è pari o dispari.
   - Trovare il massimo tra due numeri.
2. Testa tutti i metodi in un’applicazione Console e documenta brevemente il funzionamento di ciascun metodo.

### Esercizio C – Riflessione e Documentazione UML
**Obiettivo:**  
- Consolida la comprensione dei concetti statici e dei costruttori.

**Istruzioni:**
1. Scegli una delle classi sviluppate (ad esempio, `Contatore` o `Configurazione`).
2. Rivedi e, se necessario, migliora il codice per garantire una corretta gestione dei membri statici.
3. Disegna o aggiorna il diagramma UML della classe scelta, evidenziando chiaramente i membri statici e il costruttore statico (se presente).
4. Scrivi un breve commento (massimo mezza pagina) su come il costruttore statico e i membri statici influenzano il comportamento della classe.

---

*Obiettivo:* Comprendere e utilizzare correttamente i modificatori di visibilità, i costruttori (statici e di istanza) e la gestione dei membri statici per scrivere codice C# ben strutturato.

---

## Conclusioni

Il Modulo 3 ha lo scopo di:
- Approfondire il concetto di visibilità dei membri e la differenza tra membri di istanza e statici.
- Introdurre l’uso dei costruttori, compresi i costruttori statici, per l’inizializzazione efficace dei dati.
- Utilizzare classi statiche per raggruppare metodi di utilità.
- Documentare e visualizzare tali concetti attraverso diagrammi UML che evidenziano chiaramente i membri statici e le relative responsabilità.