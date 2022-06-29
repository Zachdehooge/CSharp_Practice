using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ram : Automobile
    {
        public void Ram1500()
        {
            Automobile auto = new Automobile();

            Console.WriteLine("The Ram is up now...");

            Thread.Sleep(1000);

            auto.Start();

            Thread.Sleep(2000);

            auto.Run();

            Thread.Sleep(2000);

            StillRunning();

            Thread.Sleep(2000);

            auto.Stop();

            Thread.Sleep(2000);
        }
        public void StillRunning()
        {
            Console.WriteLine("The Ram is still running!!");
        }
    }
}
