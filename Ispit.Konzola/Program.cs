using Ispit.Model.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KreirajTriUcenika();
        }

        private static void KreirajTriUcenika()
        {
            int brojac = 1;
            var listaUcenika = new List<Ucenik>();

            Console.WriteLine("Molimo da se kreiraju tri učenika.");
            while (brojac <= 3)
            {
                Console.WriteLine($"Podaci učenika {brojac}:");
                Console.WriteLine("Ime:");
                string ime = Console.ReadLine();
                Console.WriteLine("Prezime:");
                string prezime = Console.ReadLine();
                Console.WriteLine("Datum rođenja:");
                DateTime datumRodjenja;
                if (!DateTime.TryParse(Console.ReadLine(), out datumRodjenja))
                {
                    Console.WriteLine("Neispravni datum rodjenja, zapisujemo aktualni datum");
                    datumRodjenja = DateTime.Now;
                }
                Console.WriteLine("Prosjek: (koristiti decimalni zarez)");
                double prosjek;

                if (!double.TryParse(Console.ReadLine(), out prosjek))
                {
                    Console.WriteLine("Neispravni broj za prosjek, zapisujemo 1");
                    prosjek = 1.00;
                }

                var ucenik = new Ucenik(ime, prezime, datumRodjenja, prosjek);

                listaUcenika.Add(ucenik);
                brojac++;

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Svi podaci unesenih ucenika:");
            
            foreach (var ucenik in listaUcenika)
            {
                Console.WriteLine($"{ucenik.Ime} {ucenik.Prezime}, datum rođenja: {ucenik.DatumRodjenja:d}, " +
                    $"prosjek: {ucenik.Prosjek:F2}, ocjena: {ucenik.IspisProsjeka()}, starost: {ucenik.Starost()}");
            }




        }
    }
}
