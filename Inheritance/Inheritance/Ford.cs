using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace Inheritance
{
    internal class Ford : Automobile
    {
        public void F150()
        {
            Automobile auto = new Automobile();

            Console.WriteLine("The Ford is up...");

            Thread.Sleep(1000);

            auto.Start();

            Thread.Sleep(2000);

            auto.Run();

            Thread.Sleep(2000);

            BreakDown();

            Thread.Sleep(2000);

            auto.Stop();

            Thread.Sleep(2000);
        }
        public void BreakDown()
        {
            Console.WriteLine("The truck broke down... :) ");
        }
    }
}
