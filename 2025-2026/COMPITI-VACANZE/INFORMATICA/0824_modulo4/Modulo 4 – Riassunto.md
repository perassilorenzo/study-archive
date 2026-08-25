# Modulo 4 – Classi Non Istanziabili, Metodi Factory e Singleton (C#)

## Concetti Chiave:
- **Classi Non Istanziabili:**  
  - Costruttore privato e metodo factory.
- **Metodi Factory:**  
  - Creano oggetti in modo controllato.
- **Singleton:**  
  - Garanzia di una sola istanza in tutto il programma.

## UML:
- **Contatore:**
  ```
  +-----------------------------+
  |         Contatore           |
  +-----------------------------+
  | - valore: int               |
  +-----------------------------+
  | - Contatore()               |
  | +CreaContatore(): Contatore |
  | +Incrementa(): void         |
  | +Valore: int {get;}         |
  +-----------------------------+
  ```
- **Logger:**
  ```
  +------------------------------------+
  |           Logger {singleton}       |
  +------------------------------------+
  | - _istanza: Logger {static}        |
  | - _lock: object {static, readonly} |
  +------------------------------------+
  | - Logger()                         |
  | +Instance: Logger {static, get}     |
  | +Log(messaggio: string): void       |
  +------------------------------------+
  ```