using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Conditional_Statments
{
    class Nested_ex
    {
        static void Mains(string[] args)
        {
            int i = 0, j = 40;

            if (i != 0)
            {
                if (i > j)
                {
                    Console.WriteLine("i is grater than j");
                }

                else if (i < j)
                {
                    Console.WriteLine("i is less than j");                   
                }
            }

            else { Console.WriteLine("i is  equal to 0"); }

        }
    }
}
