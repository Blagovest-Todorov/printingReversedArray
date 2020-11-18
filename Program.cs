using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace _01.arrayExamplesTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Reversed : ");
            int length = 12;
            int[] arr = Enumerable.Range( 2, length  ).ToArray(); // this is -> Row (9, 8, 7, 6, 5, 4, 3, 2, 1, 0) 
                                                                     //index 0, 1, 2, ..9//for 10 items

            for (int i = length -1 ; i >= 0; i --)
            {
                int number = arr[i];
                Console.WriteLine(number);
            }
        }
    }
}
