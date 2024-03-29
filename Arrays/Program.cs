﻿using System;
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



            //normalArrays();
            //TwoDimensionalArray();
            //ThreeDimensionalArrays();
            //JaggedArray();


            #region arrays as parameters
            int[][] ClassGrades = new int[3][];
            ClassGrades[0] = new int[] { 15, 24, 22, 33 };
            ClassGrades[1] = new int[] { 23, 33, 33, 22, 1, 2 };
            ClassGrades[2] = new int[] { 32, 45, 66, 7, 4, 22 };
            for(int i=0; i<ClassGrades.Length;i++)
            {
                double averageResult = GetAverage(ClassGrades[i]);
                Console.WriteLine("The average result of Class{1} is {0}", averageResult,i+1);
                

            }
            Console.ReadKey();

            #endregion

        }


        #region normal arrays
        static void normalArrays()
        {
            int[] Markssss = new int[3] { 12, 2, 3 }; // another type of initialization.
            int[] Markss = { 1, 23, 24, 22, 23, 33 }; // this is another type.  // Can be only used in main since not using static brfore.

            Marks[0] = 5;
            Marks[1] = 10;
            Marks[2] = 12;
            Marks[3] = 15;
            Marks[4] = 16;// This is one type of initialization.

            Console.WriteLine("Lenght of an array is " + Marks.Length);
            Console.ReadKey();


        }
        #endregion


        #region 2D arrays
        static void TwoDimensionalArray()
        {
            int[,] array2D = new int[,]
            {
                {1,2},
                {3,4},
                {5,6}
            };

            int[,] array2d = { { 1, 2 }, { 3, 4 } }; //another way of initialization
            int[,] aray2d = new int[3, 2]  //another way of initialization
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };


            for (int i = 0; i < array2D.GetLength(0); i++) // nested for loop
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[1, 1] = 234;
                    Console.Write(array2D[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine("\n");
            }

            foreach (int item in array2D) // using foreach  (this is super useful to just read the values not for changing or adding liked nested loops)
            {
                Console.WriteLine("The items of array are " + item);
            }


            Console.WriteLine("The center value is " + array2D[1, 0]);
            Console.WriteLine("The length of the array is " + array2D.Length);
            Console.ReadKey();
        }
        #endregion

        #region 3D arrays
        static void ThreeDimensionalArrays()
        {
            string[,,] array3D = new string[,,]
            {
                {
                    {"Front 1st Row first","Front 1st Row second" },
                    {"Front 1st Row first element","Front 1st row second element" }
                },
                {
                    {"back 1st Row first","back 1st Row second" },
                    {"back 1st Row first element","back 1st row second element" }
                },
            };

            Console.WriteLine("The lenght of a 3D array is " + array3D.Length);
            Console.WriteLine("The value of back first row 1 element is " + array3D[1, 1, 0]);
            Console.ReadKey();
        }
        #endregion


        #region jagged arrays
        static void JaggedArray()  // These jagged arrays are called arrays inside arrays
        {

            // index                        0     1    2
            // normal array of type int  : [12],[21],[22]
            // index                                      0                     1                       2
            //jagged array of type int  : [array1([12],[21],[22]), array2([162],[27],[22]), array3([2],[21],[2])]

            //One way of declaring the jagged arrays
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4, };
            jaggedArray[2] = new int[] { 1, 2};

            Console.WriteLine("The center value{0}", jaggedArray[0][1]);
            Console.ReadKey();

            //alternate way of declaring jagged arrays
            int[] normalarray = new int[] { 2, 2, 2, 2 };
            int[][] jaggedarray2 = new int[][]
            {
               new int[] {1,2,3,4},
               new int[] {3,4,5,3,3,2 },
               normalarray // like this we can even include the normal arrays inside a jagged array
            };

            Console.WriteLine("the value of 1st middle is {0}", jaggedarray2[0][2]);
            Console.ReadKey();
        }
        #endregion

        #region arrys as parameters

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i<size;i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
        #endregion
    }
}
