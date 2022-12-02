using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
       public static int[] Marks = new int[5]; // global variable


      
        static void Main(string[] args)
        {
         int[] Markssss = new int[3] { 12, 2, 3 }; // another type.
         int[] Markss = { 1, 23, 24, 22, 23, 33 }; // this is another type.  // Can be only used in main

            Marks[0] = 5;
            Marks[1] = 10;
            Marks[2] = 12;
            Marks[3] = 15;
            Marks[4] = 16;// This is one type of initialization.

            Console.WriteLine("Lenght of an array is "+ Marks.Length);
            Console.ReadKey();
        }
    }
}
