# Modulo 4 – Classi Non Istanziabili, Metodi Factory e Singleton (C#)

---

## 1. Parte Teorica

### 1.1 Classi Non Istanziabili
In questo contesto si vuole impedire che una classe venga istanziata direttamente:
- **Metodo:** Rendere il costruttore privato.
- **Scopo:** Forzare la creazione degli oggetti tramite metodi statici (es. factory).

*Esempio:*  
La classe `Contatore` ha un costruttore privato; l'unico modo per ottenere un'istanza è usare il metodo statico `CreaContatore()`.

### 1.2 Metodi Factory
Un **metodo factory** è un metodo statico che:
- Incapsula la logica per creare oggetti.
- Consente di eseguire controlli o operazioni preliminari prima della creazione.

*Esempio:*  
La classe `Contatore` definisce un metodo factory `CreaContatore()` che restituisce una nuova istanza.

### 1.3 Classi Singleton
Il pattern **Singleton** garantisce l'esistenza di una sola istanza di una classe:
- **Caratteristiche:**
  - Costruttore privato.
  - Campo statico che conserva l'istanza.
  - Metodo (o proprietà) statico per accedere all'unica istanza.
- *Utilizzo tipico:* Gestione di log o configurazioni condivise.

### 1.4 UML
È importante documentare graficamente questi concetti.  
**Diagramma UML per la classe `Contatore` con metodo factory:**

```
+-----------------------------+
|         Contatore           |
+-----------------------------+
| - valore: int               |
+-----------------------------+
| - Contatore()               |  <-- Costruttore privato
| +CreaContatore(): Contatore |  <-- Metodo factory {static}
| +Incrementa(): void         |
| +Valore: int {get;}         |
+-----------------------------+
```

**Diagramma UML per la classe Singleton `Logger`:**

```
+------------------------------------+
|           Logger {singleton}       |
+------------------------------------+
| - _istanza: Logger {static}        |
| - _lock: object {static, readonly} |
+------------------------------------+
| - Logger()                         |  <-- Costruttore privato
| +Instance: Logger {static, get}     |
| +Log(messaggio: string): void       |
+------------------------------------+
```

---

## 2. Esercizi da Fare in Classe

### Esercizio 4.1 – Creazione della Classe `Contatore` con Metodo Factory
**Obiettivi:**  
- Rendere la classe non istanziabile direttamente.
- Creare oggetti tramite un metodo statico.

**Istruzioni:**
1. Crea la classe `Contatore` con:
   - Campo privato `valore` di tipo `int`.
   - Costruttore privato.
   - Metodo statico `CreaContatore()` che restituisce un nuovo oggetto.
   - Metodo `Incrementa()` per aumentare il valore.
2. Nel `Main()`, utilizza `CreaContatore()` per creare istanze e verifica il loro comportamento.

### Esercizio 4.2 – Implementazione di una Classe Singleton `Logger`
**Obiettivi:**  
- Creare una classe che garantisca una sola istanza.

**Istruzioni:**
1. Crea la classe `Logger` con:
   - Costruttore privato.
   - Campo statico privato `_istanza` e oggetto `_lock`.
   - Proprietà statica `Instance` per l'accesso controllato.
   - Metodo `Log(string messaggio)`.
2. Nel `Main()`, verifica che chiamate successive a `Logger.Instance` restituiscano la stessa istanza.

---

## 3. Esercizi di Approfondimento (a Casa)

### Esercizio A – Estendere `Contatore`
- Aggiungi un campo statico per contare tutte le istanze create.
- Definisci un metodo statico `ResetTotale()` per resettare tale contatore.
- Documenta il comportamento con commenti e aggiorna il diagramma UML.

### Esercizio B – Singleton per la Gestione delle Configurazioni
- Crea una classe `Configurazione` con:
  - Costruttore privato.
  - Proprietà statica `Instance`.
  - Proprietà come `Ambiente` e `Versione`.
- Modifica il `Main()` per dimostrare che le modifiche persistono.
- Disegna il relativo diagramma UML.

### Esercizio C – Disegna o Aggiorna il Diagramma UML
- Disegna (su carta o con uno strumento online) il diagramma UML per `Contatore` e `Logger` (e per `Configurazione`, se realizzata).
- Evidenzia i membri statici e i costruttori privati.

## Attività:
1. **In Classe:**  
   - Implementare `Contatore` con metodo factory.  
   - Realizzare il Singleton `Logger`.
2. **A Casa:**  
   - Estendere le funzionalità di `Contatore`.  
   - Creare un Singleton per la configurazione.  
   - Aggiornare i diagrammi UML.

*Obiettivo:* Garantire una gestione controllata della creazione degli oggetti e documentare il tutto graficamente.
