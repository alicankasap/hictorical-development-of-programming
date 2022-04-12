using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BasicCalculator
    {
        public int Factorial(int number)
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
