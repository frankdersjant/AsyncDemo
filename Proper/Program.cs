using System;
using System.Threading;
using System.Threading.Tasks;

namespace Proper
{
    class Program
    {
        static void Main(string[] args)
        {
            Morning();
        }

        public async static Task Morning()
        {
            var result = await Talking();
            await CombingHair();
            Console.ReadLine();
        }
        public async static Task<bool> Talking()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Hey I am talking");
            });

            return true;
        }

        public async static Task CombingHair()
        {
            await Task.Run(() =>
            {

                Thread.Sleep(2000);
                Console.WriteLine("Combing my hair");
            });
        }
    }
}
