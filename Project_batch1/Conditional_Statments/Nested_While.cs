using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Conditional_Statments
{
    class Nested_While
    {
        static void Mains(string[] args)
        {
            int j = 1;
            int i = 0; // initialization
            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);
                i++; // increment

                while (j < 3 )
                {
                    Console.WriteLine("*************");

                    Console.WriteLine("j = {0}", j);

                    Console.WriteLine("*************");
                    j++;
                }

            }
        }
    }
}
