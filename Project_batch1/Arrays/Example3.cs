using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_batch1.Arrays
{
    class Example3
    {
        static void Mains(string[] args)
        {
            int[] nums = new int[5] { 25, 40, 65, 98, 100 };
           

            Console.WriteLine("Maximum Value Array is : " + nums.Max());
            Console.WriteLine("Minimum Value Array is  : " + nums.Min());
            Console.WriteLine("Sum Array is  : " + nums.Sum());
            Console.WriteLine("Average Value of Array is  : " + nums.Average());
           
            Array.Sort(nums); // sorts array
            Array.ForEach(nums, n => Console.Write(n +" ,  "));
            Console.WriteLine("*******######****");

            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.Write(n + " ,  ")); // iterates array
            Console.WriteLine("*******######****");





        }
    }
}