using System;

internal class Persona
{
    // Attributi privati
    private string nome;
    private string cognome;
    private int eta;
    private string indirizzo;

    // Costruttore
    public Persona(string nome, string cognome, int eta, string indirizzo)
    {
        this.Nome = nome;
        this.Cognome = cognome;
        this.Eta = eta;
        this.Indirizzo = indirizzo;
    }

    // Proprietà Nome
    public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Il nome non può essere vuoto o composto solo da spazi.");
            nome = value.Trim();
        }
    }

    // Proprietà Cognome
    public string Cognome
    {
        get => cognome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Il cognome non può essere vuoto o composto solo da spazi.");
            cognome = value.Trim();
        }
    }

    // Proprietà Eta con validazione
    public int Eta
    {
        get => eta;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value), "L'età deve essere maggiore di 0.");
            eta = value;
        }
    }

    // Proprietà Indirizzo con validazione
    public string Indirizzo
    {
        get => indirizzo;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("L'indirizzo non può essere vuoto o composto solo da spazi.");
            indirizzo = value.Trim();
        }
    }

    // Metodo per rappresentare l'oggetto come stringa
    public override string ToString()
    {
        return $"{Nome} {Cognome}, Età: {Eta}, Indirizzo: {Indirizzo}";
    }
}