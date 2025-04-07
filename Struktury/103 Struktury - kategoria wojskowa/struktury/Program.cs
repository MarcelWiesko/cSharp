namespace _103_Struktury___kategoria_wojskowa
{
    using System;

    public enum KategoriaWojskowa
    {
        A,
        B,
        D,
        E
    }

    struct Poborowy
    {
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public KategoriaWojskowa Kategoria { get; set; }

        public Poborowy(string imie, int wiek, KategoriaWojskowa kategoria)
        {
            Imie = imie;
            Wiek = wiek;
            Kategoria = kategoria;
        }

        public void WyświetlInformacje()
        {
            Console.WriteLine($"Poborowy: {Imie}");
            Console.WriteLine($"Wiek: {Wiek}");
            Console.WriteLine($"Kategoria wojskowa: {Kategoria}");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Poborowy[] poborowi = new Poborowy[]
            {
            new Poborowy("Jan Kowalski", 22, KategoriaWojskowa.A),
            new Poborowy("Adam Nowak", 30, KategoriaWojskowa.B),
            new Poborowy("Marek Wiśniewski", 18, KategoriaWojskowa.D)
            };

            foreach (var poborowy in poborowi)
            {
                poborowy.WyświetlInformacje();
            }
        }
    }

}
