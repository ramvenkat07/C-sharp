using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();


            try //try and catch is used to insted of crashing the program we will tell the user what to do. Here if the user enter the string then we print enter correct format.
            {
                int userINputAsInt = int.Parse(userInput);// place the cursor on parse to know the possible exceptions
            }
            catch (FormatException) // here why we use format exception insted of normal exception is because the following line in try throw a FORMAT EXCEPTION.
            {
                //throw; // if we place throw it will trow the error
                Console.WriteLine("Format exception, please enter the correct type next time");

            }
            catch(OverflowException) // since we entered Format exception in above line if overfolw exception came it wont handle so we need to write separate exception for this.
            {
                Console.WriteLine("the number you entered is too big for a int32");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
            Console.ReadKey();
        }
    }
}
