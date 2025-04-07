namespace _107_ZapisOdczyt___Utworzenie___zapis
{
    using System;
    using System.IO;

    internal class Program
    {
        static void Main()
        {
            string sciezka = "liczby.txt";

            if (File.Exists(sciezka))
            {
                double suma = 0;
                using (StreamReader reader = new StreamReader(sciezka))
                {
                    string linia;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        if (double.TryParse(linia, out double liczba))
                        {
                            suma += liczba;
                        }
                    }
                }
                Console.WriteLine($"Suma liczb z pliku wynosi: {suma}");
            }
            else
            {
                Console.WriteLine("Plik liczby.txt nie istnieje. Czy chcesz go utworzyć? (tak/nie)");
                string odpowiedz = Console.ReadLine().ToLower();

                if (odpowiedz == "tak")
                {
                    using (StreamWriter writer = new StreamWriter(sciezka))
                    {
                        Console.WriteLine("Wprowadź liczby (wpisz 'stop', aby zakończyć):");
                        string linia;
                        while ((linia = Console.ReadLine()) != "stop")
                        {
                            if (double.TryParse(linia, out double liczba))
                            {
                                writer.WriteLine(liczba);
                            }
                            else
                            {
                                Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie.");
                            }
                        }
                    }

                    Console.WriteLine("Liczby zostały zapisane do pliku liczby.txt.");
                }
                else
                {
                    Console.WriteLine("Plik nie został utworzony.");
                }
            }
        }
    }

}
