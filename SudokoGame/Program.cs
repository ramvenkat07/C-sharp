using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokoGame
{
    class Program
    {
        static int[] MyRandomArray = new int[9];
       static bool EnteredValu = true;
        static void Main(string[] args)
        {
            while(true)
            {
                
                    if(EnteredValu == true)
                    {
                        Console.Clear();
                        sudokoo();
                        SudokoPrint();
                    }
            }

        }
        static void sudokoo()
        {
            int[] sudoko = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random rnd = new Random();
           MyRandomArray = sudoko.OrderBy(x => rnd.Next()).ToArray();

        }

        static void SudokoPrint()
        {
            EnteredValu = false;

            Console.WriteLine("      |      |      |");
            Console.WriteLine("  {0}   |  {1}   |  {2}   |", MyRandomArray[0] , MyRandomArray[1], MyRandomArray[2]);
            Console.WriteLine("______|______|______|");
            Console.WriteLine("      |      |      |");
            Console.WriteLine("  {0}   |  {1}   |  {2}   |", MyRandomArray[3],"X", MyRandomArray[5]);
            Console.WriteLine("______|______|______|");
            Console.WriteLine("      |      |      |");
            Console.WriteLine("  {0}   |  {1}   |  {2}   |", MyRandomArray[6], MyRandomArray[7], MyRandomArray[8]);
            Console.WriteLine("______|______|______|");

            int X = MyRandomArray[4];
            Console.Write("What is the missing value??  Ans:");
            int readValue = Convert.ToInt32(Console.ReadLine());
            if (readValue == X)
            {
                EnteredValu = true;
            }
            else
            {
                Console.WriteLine("You have entered wrong ans*****     Press Enter to continue");
                Console.ReadLine();
                EnteredValu = true;

            }

        }
    }

}
