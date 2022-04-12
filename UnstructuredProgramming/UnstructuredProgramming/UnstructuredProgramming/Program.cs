using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnstructuredProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 6;

            int factorial1 = 1;
            int factorial2 = 1;

            for (int i = 1; i < number1; i++)
            {
                factorial1 *= i;
            }

            for (int i = 1; i < number2; i++)
            {
                factorial2 *= i;
            }

            Console.WriteLine(factorial1);
            Console.WriteLine(factorial2);

            Console.ReadLine();
        }
    }
}
