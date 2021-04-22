using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Conditional_Statments
{
    class For_ex3
    {
        static void Mains(string[] args)
        {
            int i = 1, j = 5;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");
            i++ < j--;
            Console.WriteLine($"Iterator: i={i}, j={j}"))
            {
            }

        }
    }
}
