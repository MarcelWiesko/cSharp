namespace Zwierze_konstruktor_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Zwierze
    {
        public Zwierze(string gatunek)
        {
            this.gatunek = gatunek;
        }

        public string gatunek;
    }

    class Pies : Zwierze
    {
        public Pies(string gatunek, string rozmiar) : base(gatunek)
        {
            this.rozmiar = rozmiar;
        }

        public string rozmiar;
    }

    class Kot : Zwierze
    {
        public Kot(string gatunek, string rasa) : base(gatunek) 
        {
            this.rasa = rasa;
        }

        public string rasa;
    }
}
