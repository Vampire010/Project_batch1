using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Conditional_Statments
{
    class for_ex1
    {
        static void Mains(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

                if (i == 5)
                    break;
            }

        }
    }
}
