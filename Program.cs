namespace Methode_Ubergabewert001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck rechteck = new Rechteck();
            rechteck.A = int.Parse(Console.ReadLine());
            rechteck.B = int.Parse(Console.ReadLine());
            Console.WriteLine(rechteck.getflache());
        }
        public class Rechteck
        {
            public int A { get; set; }
            public int B { get; set; }
            public int Flache { get; set; }
            public int getflache()
            {

                Flache = A * B;
                return Flache;
            }
        }
    }
}

