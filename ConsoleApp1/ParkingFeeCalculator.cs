using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ParkingFeeCalculator
    {
        public int CalculateMoreThanSixHours(int hours)
        {
            int fee = 0;
            while (hours >= 6)
            {
                fee += 50;
                hours -= 6;
            }
            fee += hours * 10;
            return fee;
        }
        public int TotalParkingFee(int[] parkHour)
        {
            int totalFee = 0;
            for(int i=0; i<parkHour.Length; i++)
            {
                if (parkHour[i] <= 5)
                {
                    totalFee += parkHour[i] * 10; 
                }
                else if (parkHour[i] == 6)
                {
                    totalFee += 50;
                }
                else if (parkHour[i] > 6)
                {
                    int result = CalculateMoreThanSixHours(parkHour[i]);
                    totalFee += result;
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

        public int UserParkingFee(int userHour) {
            int userFee = CalculateMoreThanSixHours(userHour);
            return userFee;
        }
    }
}
