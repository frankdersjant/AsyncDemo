using System;
using System.Threading;

namespace NopeNope
{
    class Program
    {
        static void Main(string[] args)
        {
            Talking();
            CombingHair();
        }

        public static void Talking()
        {
            Console.WriteLine("Hey I am talking");
            Thread.Sleep(2000);
        }

        public static void CombingHair()
        {
            Console.WriteLine("Combing my hair");
            Thread.Sleep(2000);
        }
    }
}
