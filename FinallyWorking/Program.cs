using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            Talking();
            CombingHair();
            Console.ReadLine();
        }

        public async static void Talking()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Hey I am talking");
            });
        }

        public async static void CombingHair()
        {
            await Task.Run(() =>
            {
               
                Thread.Sleep(2000);
                Console.WriteLine("Combing my hair");
            });
        }
    }
}
