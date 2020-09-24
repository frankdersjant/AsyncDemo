using System;
using System.Threading;

namespace ConsoleApp1
{
    public class HeavyClass
    {
        public bool isComplete { get; set; }

        public void HeavyClassDoingStuff()
        {
            this.isComplete = false;
            Console.WriteLine("Doing work");

            LongStuff();

            Console.WriteLine("Done heavy work");
            isComplete = true;
        }

        private void LongStuff()
        {
            Console.WriteLine("Im busy");
            Thread.Sleep(2000);
        }
    }
}
