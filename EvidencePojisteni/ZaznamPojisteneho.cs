﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    // Záznam v databázi
    internal class ZaznamPojisteneho
    {
        // Jméno, příjmení, telefonní číslo a věk v záznamu
        protected string jmeno;
        protected string prijmeni;
        protected long telefonniCislo;
        protected int vek;
        
        public string Jmeno { get { return jmeno; } set { jmeno = value; } }
        public string Prijmeni { get { return prijmeni; } set { prijmeni = value; } }
        public long TelefonniCislo { get { return telefonniCislo;} set { telefonniCislo = value; } }
        public int Vek { get; set; }

        // Konstruktor s parametry - vytvoří novou instanci pojištěného
        public ZaznamPojisteneho(string jmeno, string prijmeni, long telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni= prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
        
        // Výpis záznamu
        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + TelefonniCislo;
        }
                      
    
    }
}
