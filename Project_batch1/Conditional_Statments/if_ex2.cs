using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Conditional_Statments
{
    class if_ex2
    {


                static void Mains(string[] args)
                 {
                            int i = 30, j = 40;
            
                            if (i > j)
                            {
                                Console.WriteLine("i is greater than j");
                            }

                            else if (i < j)
                            {
                                Console.WriteLine("i is less than j");
                            }

                            else if (i == j)
                            {
                                Console.WriteLine("i is equal to j");
                            }

                            else
                             {
                                 Console.WriteLine("not number");
                             }

                  }

    }
}
