using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    // Třída reprezentuje databázi pojištěných
    internal class Pojistenec
    {
        // Databáze se záznamy
        private Databaze databaze;

        // Vytvoří novou instanci pojištěného
        public Pojistenec()
        {
            databaze = new Databaze();
        }

        // Vyzve uživatele k vytvoření pojištěného
        public void Vytvor()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo: ");
            int telefonniCislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("\nData byla uložena. Pokračujte stisknutím libovolné klávesy...");
            Console.ReadKey();

            // Zápis údajů do Listu databáze v záznamu
            databaze.Vytvor(jmeno, prijmeni, telefonniCislo, vek);
        }

        public void Hledat()
        {
            // Podle jména a příjmení vyhledá pojištěného ze záznamu. Základ je v Databázi
            Console.WriteLine();
            Console.WriteLine("Vyhledávám: ");
            Console.WriteLine("Zadej jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();

            List<ZaznamPojisteneho> nalezeno = databaze.NalezeniPojisteneho(jmeno, prijmeni);
            if (nalezeno.Count() > 0)
            {
                Console.WriteLine("\nNalezeny tyto záznamy: ");
                foreach (ZaznamPojisteneho z in nalezeno)
                    Console.WriteLine(z);
                    Console.WriteLine("\nPokračujte stisknutím libovolné klávesy...");
            }
            else
                // Nenalazeno
                Console.WriteLine("\nNebyly nalezeny žádné záznamy.\nPokračujte stisknutím libovolné klávesy...");
        }

        public void Vypis()
        {
            databaze.Vypis();
        }

    }
}
