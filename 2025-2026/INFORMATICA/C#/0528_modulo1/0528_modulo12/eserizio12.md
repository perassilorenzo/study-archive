# Esercizio 1.2 – Diagramma UML della Classe Persona

## Diagramma UML

```text
+----------------------------------+
|             Persona             |
+----------------------------------+
| - nome : string                 |
| - cognome : string              |
| - eta : int                     |
+----------------------------------+
| + Persona(nome, cognome, eta)   |
| + Nome : string { get; set; }   |
| + Cognome : string { get; set;} |
| + Eta : int { get; set; }       |
+----------------------------------+
```