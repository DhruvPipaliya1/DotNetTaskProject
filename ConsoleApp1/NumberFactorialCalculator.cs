using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class NumberFactorialCalculator
    {
        public int FindFactorial(int number)
        {
            if(number <= 1)
            {
                return 1;
            }

            return number * FindFactorial(number - 1);

        }
    }
}
