using System;
using System.Threading;

namespace WhyNope
{
    class Program
    {
        static void Main(string[] args)
        {
            Talking();
            CombingHair();
        }

        public async static void Talking()
        {
            Console.WriteLine("Hey I am talking");
            Thread.Sleep(2000);
        }

        public async static void CombingHair()
        {
            Console.WriteLine("Combing my hair");
            Thread.Sleep(2000);
        }
    }
}
