using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Automobile
    {
        public void Start()
        {
            Console.WriteLine("The car is starting...");

            Thread.Sleep(1000);

            Console.WriteLine("The car has been started...");
        }

        public void Run()
        {
            Console.WriteLine("The car is in drive and going...");
        }

        public void DestinationReached()
        {
            Console.WriteLine("The vehicle reached the destination!");
        }

        public void Stop()
        {
            Console.WriteLine("The car has been stopped...");

            Console.WriteLine("Have a nice day!");
        }
    }
}