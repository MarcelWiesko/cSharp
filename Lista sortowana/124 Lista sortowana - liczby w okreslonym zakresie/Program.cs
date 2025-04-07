namespace _124_Lista_sortowana___liczby_w_okreslonym_zakresie
{
    internal class Program
    {
        static void Main()
        {
            SortedList<int, string> lista = new SortedList<int, string>
        {
            { 3, "Anna" },
            { 15, "Tomasz" },
            { 25, "Michał" },
            { 50, "Kasia" },
            { 75, "Piotr" },
            { 100, "Alicja" },
            { 200, "Jan" }
        };

            Console.WriteLine("Podaj dolną granicę zakresu:");
            int dolnaGranica = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj górną granicę zakresu:");
            int gornaGranica = int.Parse(Console.ReadLine());

            Console.WriteLine("\nElementy w podanym zakresie:");

            foreach (var para in lista)
            {
                if (para.Key >= dolnaGranica && para.Key <= gornaGranica)
                {
                    Console.WriteLine($"Klucz: {para.Key}, Wartość: {para.Value}");
                }
            }
        }
    }
}
