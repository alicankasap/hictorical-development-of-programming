using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();

            int number1 = 5;
            int number2 = 6;

            Console.WriteLine(basicCalculator.Factorial(number1));
            Console.WriteLine(basicCalculator.Factorial(number2));

            Console.ReadLine();
        }
    }
}
