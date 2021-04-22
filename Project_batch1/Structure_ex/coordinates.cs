using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Structure_ex
{
    class coordinates
    {
        struct Coordinate
        {
            public int x  ;
            public int y  ;

            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

        }

        static void Main(string[] args)
        {
            Coordinate point = new Coordinate(10, 20);

            Console.WriteLine(point.x); //output: 10
            Console.WriteLine(point.y); //output: 20

        }
    }
}
