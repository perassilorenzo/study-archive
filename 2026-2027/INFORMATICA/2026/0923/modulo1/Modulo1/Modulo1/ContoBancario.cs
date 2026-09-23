using System;

internal class ContoBancario
{
    // Attributi privati
    private string numeroConto;
    private double saldo;

    // Costruttore
    public ContoBancario(string numeroConto, double saldoIniziale)
    {
        this.NumeroConto = numeroConto;

        if (saldoIniziale >= 0)
        {
            this.saldo = saldoIniziale;
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(saldoIniziale), "Il saldo iniziale non può essere negativo.");
        }
    }

    // Proprietà NumeroConto
    public string NumeroConto
    {
        get => numeroConto;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Il numero di conto non può essere vuoto.");
            numeroConto = value.Trim();
        }
    }

    // Proprietà Saldo (lettura pubblica, modifica privata)
    public double Saldo
    {
        get => saldo;
        private set => saldo = value;
    }

    // Metodo per depositare denaro
    public void Deposita(double importo)
    {
        if (importo > 0)
        {
            saldo += importo;
            Console.WriteLine($"Deposito di {importo:C} effettuato. Saldo attuale: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Errore: l'importo da depositare deve essere maggiore di 0.");
        }
    }

    // Metodo per prelevare denaro
    public void Preleva(double importo)
    {
        if (importo <= 0)
        {
            Console.WriteLine("Errore: l'importo da prelevare deve essere maggiore di 0.");
        }
        else if (saldo - importo >= 0)
        {
            saldo -= importo;
            Console.WriteLine($"Prelievo di {importo:C} effettuato. Saldo rimanente: {saldo:C}");
        }
        else
        {
            Console.WriteLine($"Errore: saldo insufficiente per prelevare {importo:C}. Saldo disponibile: {saldo:C}");
        }
    }
}