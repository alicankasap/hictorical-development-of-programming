using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int number1 = 5;
            int number2 = 6;

            Console.WriteLine(calculator.Factorial(number1));
            Console.WriteLine(calculator.Factorial(number2));

            Console.ReadLine();
        }
    }
}
