using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1c
{
 
    public class Persona
    {
        const int MAX_LENGHT = 100;
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
            set
            {
                if (value.Length > 0 && value.Length < MAX_LENGHT) nome = value;
                else return;
            }
        }

        // Proprietà per 'Cognome'
        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (value.Length > 0 && value.Length < MAX_LENGHT) nome = value;
                else return;
            }
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