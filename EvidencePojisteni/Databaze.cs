using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    // Třída spravuje kolekci záznamů/ pojištěných
    internal class Databaze
    {
        // Kolekce záznamů
        private List<ZaznamPojisteneho> zaznam;

        // Vytvoří novou instanci databáze - voláme na konstruktoru Databaze()
        public Databaze()
        {
            zaznam = new List<ZaznamPojisteneho>();
        }

        // Přidá nový záznam do databáze - vytvoří profil pojištěného
        public void Vytvor(string jmeno, string prijmeni, long telefonniCislo, int vek)
        {
            zaznam.Add(new ZaznamPojisteneho(jmeno, prijmeni, telefonniCislo, vek));
        }

        // Vyhledání pojištěného podle jména a příjmení
        public List<ZaznamPojisteneho> NalezeniPojisteneho(string jmeno, string prijmeni)
        {
            List<ZaznamPojisteneho> nalezeno = new List<ZaznamPojisteneho>();
            foreach (ZaznamPojisteneho pojisteny in zaznam)
            {
                if ((pojisteny.Jmeno == jmeno) && (pojisteny.Prijmeni == prijmeni))
                { nalezeno.Add(pojisteny); }
            }
            return nalezeno;
        }

        // Výpis všech pojištěných v záznamu
        public void Vypis()
        {
            // Projede celý záznam a napíše veškerý obsah
            foreach (ZaznamPojisteneho zaznam in zaznam)
            {
                Console.WriteLine();
                Console.Write(zaznam);
            }

            Console.WriteLine("\n\nPokračujte stisknutím libovolné klávesy...\n");
        }

       
    }
}
