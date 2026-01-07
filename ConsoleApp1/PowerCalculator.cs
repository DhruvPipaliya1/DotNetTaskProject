using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PowerCalculator
    {
        public int CalculatePower(int baseNum, int exponent)
        {
            if(exponent == 0)
            {
                return 1;
            }

            return baseNum * CalculatePower(baseNum, exponent - 1); ;
        }
    }
}
