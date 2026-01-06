using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class TemperatureAnalyzer
    {
        public int CalculateHotDays(int[] temperature)
        {
            int hotDays = 0;
            for(int i=0; i<temperature.Length; i++)
            {
                if (temperature[i] > 30)
                {
                    hotDays++;
                }
            }
            return hotDays;
        }

        public int AverageTemperature(int[] temperature)
        {
            int sum = 0;
            for(int i=0; i<temperature.Length; i++)
            {
                sum += temperature[i];
            }
            return sum / temperature.Length;
        }

        public string CategorizeTemperature(int temperature)
        {
            if (temperature < 20)
            {
                return "Cold";
            }
            if (temperature > 30)
            {
                return "Hot";
            }
            return "Normal";

        }
    }
}
