using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Arrays
{
    class Example2
    {
        static void Maind(string[] args)
        {
            string[] cities = { "Mumbai", "London", "New York" };

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);

            }

            Console.WriteLine("*******######****");

            foreach(string name in cities)
            {
                Console.WriteLine(name);
            }

        }
    }
}
