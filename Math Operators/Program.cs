using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user for input
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Prints the ouput of adding, subtracting, multiplying, and dividing 
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

            Console.ReadKey();
            


        }
    }
}
