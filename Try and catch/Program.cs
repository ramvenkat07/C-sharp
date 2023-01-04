using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy
{
    class Program
    {
        static int age;
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your age???");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number...");
                Console.ReadLine();
            }

            Console.WriteLine("Age is " + age);
            Console.ReadLine();
        }
    }
}
