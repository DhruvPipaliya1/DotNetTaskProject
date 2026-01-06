using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class TemperatureAnalyzer
    {
        public (int HotDays, int Average) LoopCalculation(int[] temp)
        {
            int HotDays = 0;
            int sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
                if (temp[i] > 30)
                {
                    HotDays++;
                }
            }
            int Average = sum / temp.Length;
            return (HotDays, Average);
        }
        public int CalculateHotDays(int[] temperature)
        {
            var result = LoopCalculation(temperature);
            return result.HotDays;
        }

        public int AverageTemperature(int[] temperature)
        {
            var result = LoopCalculation(temperature);
            return result.Average;
        }

        public string CategorizeTemperature(int temperature)
        {
            if (temperature < 20)
            {
                return "Cold";
            }
            else if (temperature > 30)
            {
                return "Hot";
            }
            return "Normal";

        }
    }
}
