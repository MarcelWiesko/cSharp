namespace _116_Lista___liczba_w_danym_miejscu_w_liscie
{
    internal class Program
    {
        static void Main()
        {
            List<int> liczby = new List<int> { 10, 20, 30 };

            liczby.Insert(0, 25);

            liczby.Add(49);

            Console.WriteLine("Lista liczb:");
            foreach (var liczba in liczby)
            {
                Console.WriteLine(liczba);
            }
        }
    }
}