using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokoGame
{
    class ToChangePosition
    {
        static string[] MyRandomArray = new string[9];
        static bool EnteredValu = true;
        static string missing;
        static void Main(string[] args)
        {
            while (true)
            {

                if (EnteredValu == true)
                {
                    Console.Clear();
                    sudokoo();
                    SudokoPrint();
                }
            }

        }
        static void sudokoo()
        {
            string[] sudoko = new string[] { "0","1","2","3","4","5","6","7","8" };
            Random rnd = new Random();
            MyRandomArray = sudoko.OrderBy(x => rnd.Next()).ToArray();
            missing = MyRandomArray[Convert.ToInt32(MyRandomArray[4])];
            MyRandomArray[Convert.ToInt32(MyRandomArray[4])] = "x";

        }

        static void SudokoPrint()
        {
            EnteredValu = false;

            Console.WriteLine("      |      |      |");
            Console.WriteLine("  {0}   |  {1}   |  {2}   |", MyRandomArray[0], MyRandomArray[1], MyRandomArray[2]);
            Console.WriteLine("______|______|______|");
            Console.WriteLine("      |      |      |");
            Console.WriteLine("  {0}   |  {1}   |  {2}   |", MyRandomArray[3], MyRandomArray[4], MyRandomArray[5]);
            Console.WriteLine("______|______|______|");
            Console.WriteLine("      |      |      |");
            Console.WriteLine("  {0}   |  {1}   |  {2}   |", MyRandomArray[6], MyRandomArray[7], MyRandomArray[8]);
            Console.WriteLine("______|______|______|");

            string X = MyRandomArray[4];
            Console.WriteLine("\n");
            Console.Write("What is the missing value(between 0 & 8)??  Ans:");
            int readValue = Convert.ToInt32(Console.ReadLine());
            if (readValue ==Convert.ToInt32(missing))
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

