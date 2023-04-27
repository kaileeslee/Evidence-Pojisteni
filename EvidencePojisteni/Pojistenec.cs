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
            string telefonniCislo = Console.ReadLine();
            Console.WriteLine("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Data byla uložena. Pokračujte stisknutím libovolné klávesy...");
            Console.ReadLine();

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
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (ZaznamPojisteneho z in nalezeno)
                    Console.WriteLine(z);
            }
            else
                // Nenalazeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }

        public void Vypis()
        {
            databaze.Vypis();
        }

    }
}
