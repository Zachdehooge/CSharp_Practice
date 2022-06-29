using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Each
{
    internal class ForEach
    {
        public void Groceries()
        {

            string[] groceryList = { "Marinara", "Pineapple", "Cheese", "Crust", "Pepperoni"};

            Console.WriteLine("Starting List...");

            Console.WriteLine();

            foreach(var gro in groceryList)
            {
                Console.WriteLine("Adding " + gro + " to the list...");

                Console.WriteLine();

                Thread.Sleep(1000);

                Console.WriteLine(gro + " added to the list");

                Console.WriteLine();

                Thread.Sleep(1000); 
            }

            Console.WriteLine("The finished list is: " + "[{0}]", string.Join(", ", groceryList));
        }
    }
}

