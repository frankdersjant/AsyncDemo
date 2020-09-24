using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            HeavyClass heavyClass = new HeavyClass();
            heavyClass.HeavyClassDoingStuff();

            while (!heavyClass.isComplete)
            {
                Console.WriteLine(".....");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

    }
}
