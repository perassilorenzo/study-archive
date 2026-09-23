using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TEST CLASSE PERSONA ===");

        try
        {
            // Creazione oggetti Persona
            Persona p1 = new Persona("Mark", "Zuck", 21, "Via Roma 10, Milano");
            Persona p2 = new Persona("Marko", "Weilfikparko", 67, "Corso Italia 5, Torino");

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            // Modifica valida
            Console.WriteLine("\n--- Modifica dati p1 ---");
            p1.Nome = "Mark Elliot";
            p1.Eta = 22;
            Console.WriteLine(p1);

            // Test validazione con età non valida (gestita con try-catch)
            Console.WriteLine("\n--- Test età negativa (-5) ---");
            p1.Eta = -5;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore catturato correttamente: {ex.Message}");
        }

        Console.WriteLine("\n=================================");
        Console.WriteLine("=== TEST CLASSE CONTO BANCARIO ===");

        try
        {
            // Creazione oggetto ContoBancario
            ContoBancario conto = new ContoBancario("IT1234567890", 500.00);
            Console.WriteLine($"Conto N°: {conto.NumeroConto} | Saldo iniziale: {conto.Saldo:C}\n");

            // Test deposito
            conto.Deposita(150.50);

            // Test prelievo valido
            conto.Preleva(200.00);

            // Test prelievo con saldo insufficiente
            conto.Preleva(1000.00);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore conto bancario: {ex.Message}");
        }

        Console.WriteLine("\nPremi un tasto per uscire...");
        Console.ReadKey();
    }
}

/*
 * +-------------------------------------------------+
|                    Persona                      |
+-------------------------------------------------+
| - nome: string                                  |
| - cognome: string                               |
| - eta: int                                      |
| - indirizzo: string                             |
+-------------------------------------------------+
| +Persona(nome: string, cognome: string,         |
|          eta: int, indirizzo: string)           |
| +Nome: string {get; set;}                       |
| +Cognome: string {get; set;}                    |
| +Eta: int {get; set;}                           |
| +Indirizzo: string {get; set;}                  |
| +ToString(): string                             |
+-------------------------------------------------+


*/


/*
 * +-------------------------------------------------+
|                  ContoBancario                  |
+-------------------------------------------------+
| - numeroConto: string                           |
| - saldo: double                                 |
+-------------------------------------------------+
| +ContoBancario(numeroConto: string,             |
|               saldoIniziale: double)            |
| +NumeroConto: string {get; set;}                |
| +Saldo: double {get;}                           |
| +Deposita(importo: double): void                |
| +Preleva(importo: double): void                 |
+-------------------------------------------------+
*/