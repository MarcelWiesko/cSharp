namespace _86_klasy_abstrakcyjne_Platnosc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Platnosc karta = new KartaKredytowa();
            Platnosc przelew = new PrzelewBankowy();

            Console.WriteLine($"Płatnośc kartą w wyysokosci {karta.PrzetworzPlatnosc(120)}zł");
            Console.WriteLine($"Płatność przelewem w wysokości {przelew.PrzetworzPlatnosc(151)}zł");
        }
    }

    abstract class Platnosc
    {
        public abstract double PrzetworzPlatnosc(double kwota);
    }

    class KartaKredytowa : Platnosc
    {
        public double podatek = 1.1d;

        public override double PrzetworzPlatnosc(double kwota)
        {
            return kwota * podatek;
        }
    }

    class PrzelewBankowy : Platnosc
    {
        public double podatek = 1.2d;

        public override double PrzetworzPlatnosc(double kwota)
        {
            return kwota * podatek;
        }
    }
}
