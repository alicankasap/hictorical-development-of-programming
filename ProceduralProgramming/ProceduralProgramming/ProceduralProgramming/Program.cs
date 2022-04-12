using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 6;

            Console.WriteLine(Factorial(number1));
            Console.WriteLine(Factorial(number2));

            Console.ReadLine();
        }

        static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i < number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
