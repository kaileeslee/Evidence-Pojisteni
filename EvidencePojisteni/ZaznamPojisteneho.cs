using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class ZaznamPojisteneho
    {
        protected string jmeno;
        protected string prijmeni;
        protected string telefonniCislo;
        protected int vek;
        
        public string Jmeno { get { return jmeno; } set { jmeno = value; } }
        public string Prijmeni { get { return prijmeni; } set { prijmeni = value; } }
        public string TelefonniCislo { get { return telefonniCislo;} set { telefonniCislo = value; } }
        public int Vek { get; set; }

        // Konstruktor s parametry - vytvoří novou instanci pojištěného
        public ZaznamPojisteneho(string jmeno, string prijmeni, string telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni= prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
        
        // Výpis záznamu
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + TelefonniCislo;
        }
                      
    
    }
}
