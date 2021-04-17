using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Arrays
{
    class Example4
    {
        static void Mains(string[] args)
        {
            int[ , ] arr2d = new int[3, 2]{
                                            {1, 2},
                                            {3, 4},
                                            {5, 6}
                                        };

            Console.WriteLine(arr2d[0, 0]); //returns 1
            Console.WriteLine(arr2d[0, 1]); //returns 2
            Console.WriteLine(arr2d[1, 0]); //returns 3
            Console.WriteLine(arr2d[1, 1]); //returns 4
            Console.WriteLine(arr2d[2, 0]); //returns 5
            Console.WriteLine(arr2d[2, 1]); //returns 6

            Console.WriteLine("*******######****");
            Console.WriteLine("*******######****");


            foreach (int num in arr2d)
            {
                Console.WriteLine(num);
            }

        }
    }
}
