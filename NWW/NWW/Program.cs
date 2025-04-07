namespace NWW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nwd to:" + Nwd(36, 12));
            Console.WriteLine("NWW to:" + NWW(8, 12));
           
        }

        static int Nwd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Nwd(b, a % b);
        }

        static int NWW(int a, int b)
        {
            return Math.Abs(a * b) / Nwd(a, b);
        }
    }
}
