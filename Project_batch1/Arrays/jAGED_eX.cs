using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Arrays
{
    class jAGED_eX
    {
        static void Mains(string[] args)
        {
            int[][] jArray = new int[2][]
                                           {
                                            new int[3]{1, 2, 3},
                                            new int[4]{4, 5, 6, 7}
                                           };
            Console.WriteLine(jArray[0][0]); //returns 1
            Console.WriteLine(jArray[0][1]); //returns 2
            Console.WriteLine(jArray[0][2]); //returns 3
            Console.WriteLine(jArray[1][0]); //returns 4
            Console.WriteLine(jArray[1][1]); //returns 5
            Console.WriteLine(jArray[1][2]); //returns 6
            Console.WriteLine(jArray[1][3]); //returns 7
        }
    }
}
