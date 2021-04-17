using System;

namespace Project_batch1
{
    class Program
    {
        static void Mains(string[] args)
        {
         
            int[] evenNums = new int[5] { 25 , 40 , 65 , 98 ,100 };

            //Console.WriteLine(evenNums);

            for (int i = 1; i < evenNums.Length-1; i++)
            {
                Console.WriteLine(evenNums[i]);
               
            }

            Console.WriteLine("*******######****");

            foreach (int num in evenNums)
            {
                Console.WriteLine(num);
            }


        }
    }

}
