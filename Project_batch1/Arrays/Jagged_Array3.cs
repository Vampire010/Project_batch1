﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Arrays
{
    class Jagged_Array3
    {
        static void Mains(string[] args)
        {
            int[][][] intJaggedArray = new int[2][][]
                                                    {
                                                        new int[2][]
                                                        {
                                                            new int[3] { 1, 2, 3},
                                                            new int[2] { 4, 5}
                                                        },

                                                        new int[1][]
                                                        {
                                                             new int[3] { 7, 8, 9}
                                                        }
                                                    };

            Console.WriteLine(intJaggedArray[0][0][0]); // 1
            Console.WriteLine(intJaggedArray[0][1][1]); // 5
            Console.WriteLine(intJaggedArray[1][0][2]); // 9
        }
    }
}
