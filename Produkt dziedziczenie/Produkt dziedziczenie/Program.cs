using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Produkt_dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elektronika[] produkty = new Elektronika[3];
                produkty[0]= new Elektronika { nazwa = "telefon", cena = 2099, gwarancja = 7 };
                produkty[1] = new Elektronika { nazwa = "smartwatch", cena = 799, gwarancja = 3 };
                produkty[2]= new Elektronika { nazwa = "słuchawki", cena = 199, gwarancja = 5 };
            
            foreach (var produkt in produkty)
            {
                Console.WriteLine($"Produkt: produkt.nazwa, Cena: {produkt.cena}, gwarancja: {produkt.gwarancja}");
            }
            
        }
    }
    
    class Produkt
    {
        public string nazwa;
        public int cena;
    }

    class Elektronika : Produkt
    {
        public int gwarancja;
    }

}
