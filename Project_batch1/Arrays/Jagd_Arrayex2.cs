using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Arrays
{
    class Jagd_Arrayex2
    {
        static void Mains(string[] args)
        {
            int[][,] jArray = new int[2][,];
            
            jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };
            
            Console.WriteLine(jArray[0][1, 1]); //returns 4
            Console.WriteLine(jArray[1][1, 0]); //returns 9
            Console.WriteLine(jArray[1][1, 1]); //returns 10
        }
    }

}
