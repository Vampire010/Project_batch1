using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1
{
    class Local_Global_Variables
    {
        int a = 10; int b = 20;

        static int m = 50; static int n = 10;
        public void add(int x , int y)
        {
            int z = x + y;
            Console.WriteLine("Addition of Two Elements x and Y is :  " +z);
        }

        public void mul()
        {
            int d = a * b;
            Console.WriteLine("Addition of Two Elements x and Y is :  " + d);
        }

        static public void div()
        {
            int e = m / n;
            Console.WriteLine("Addition of Two Elements x and Y is :  " +e );

        }


        static void Main(string[] args)
        {
            Local_Global_Variables lvar = new Local_Global_Variables();
            
            lvar.add(25,30);
           
            lvar.mul();

            div();

        }
    }


}
