// See https://aka.ms/new-console-template for more information
using EvidencePojisteni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Instance pojištěného
Pojistenec pojistenec = new Pojistenec();
char volba = '0';

// Hlavní cyklus
while (volba!='4')
{
    Console.WriteLine("----------------------------\nEvidence pojištěných\n----------------------------");
    Console.WriteLine("\nVyberte si akci: ");
    Console.WriteLine("1 - Přidat nového pojištěného\n2 - Vypsat všechny pojištěné\n3 - Vyhledat pojištěného\n4 - Konec");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    // Reakce na volbu
    switch (volba)
    {
        case '1':
            pojistenec.Vytvor();
            break;
        case '2':
            pojistenec.Vypis();
            break;
        case '3':
            pojistenec.Hledat();
            break;
        case '4':
            Console.WriteLine("Program se vypne...");
            break;
        default: Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.ReadKey();
}
