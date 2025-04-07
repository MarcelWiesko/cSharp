namespace _128_Slowniki___zmiana_ceny
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, double> produkty = new Dictionary<string, double>
        {
            { "Jabłko", 3.50 },
            { "Banan", 2.30 },
            { "Pomarańcza", 4.20 },
            { "Gruszka", 3.80 }
        };

            Console.WriteLine("Początkowe ceny produktów:");
            foreach (var produkt in produkty)
            {
                Console.WriteLine($"{produkt.Key}: {produkt.Value} zł");
            }

            Console.WriteLine("\nPodaj nazwę produktu, którego cenę chcesz zmienić:");
            string produktDoZmiany = Console.ReadLine();

            if (produkty.ContainsKey(produktDoZmiany))
            {
                Console.WriteLine($"Podaj nową cenę dla produktu {produktDoZmiany}:");
                double nowaCena;
                if (double.TryParse(Console.ReadLine(), out nowaCena))
                {
                    produkty[produktDoZmiany] = nowaCena;
                    Console.WriteLine($"Cena produktu {produktDoZmiany} została zmieniona na {nowaCena} zł.");
                }
                else
                {
                    Console.WriteLine("Niepoprawna cena.");
                }
            }
            else
            {
                Console.WriteLine("Podany produkt nie znajduje się w słowniku.");
            }

            Console.WriteLine("\nZaktualizowane ceny produktów:");
            foreach (var produkt in produkty)
            {
                Console.WriteLine($"{produkt.Key}: {produkt.Value} zł");
            }
        }
    }
}
