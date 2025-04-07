namespace _94_interfejsy_ILadowarka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILadowarka telefon = new Telefon();
            telefon.Laduj();
            telefon.SprawdzBaterie();
        }
    }
    interface ILadowarka
    {
        void Laduj();
        void SprawdzBaterie();
    }
    class Telefon : ILadowarka
    {
        public void Laduj()
        {
            Console.WriteLine("Telefon się ładuje");
        }
        public void SprawdzBaterie()
        {
            Console.WriteLine("Bateria w dobrym stanie");
        }

    }
}
