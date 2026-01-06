using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ParkingFeeCalculator
    {
        public int TotalParkingFee(int[] parkHour)
        {
            int totalFee = 0;
            for(int i=0; i<parkHour.Length; i++)
            {
                if (parkHour[i] <= 5)
                {
                    totalFee += parkHour[i] * 10; 
                }
                if (parkHour[i] == 6)
                {
                    totalFee += 50;
                }
                if (parkHour[i] > 6)
                {
                    while (parkHour[i] > 6)
                    {
                        totalFee += 50;
                        parkHour[i] -= 6;
                    }
                    totalFee += parkHour[i] * 10;
                }
            }
            return totalFee;
        }

        public int CalculateFullDaysParkers(int[] parkHour)
        {
            int parkers = 0;
            for (int i = 0; i < parkHour.Length; i++) {
                if (parkHour[i] >= 8)
                {
                    parkers++;
                }
            }
            return parkers;
        }
    }
}
