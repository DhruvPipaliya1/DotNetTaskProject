using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class EmployeeAttendenceTracker
    {
        public int CalculateTotalHour(int[] attendence)
        {
            int totalHour = 0;
            for (int i = 0; i < attendence.Length; i++)
            {
                totalHour += attendence[i];
            }
            return totalHour;
        }

        public int CalculateOvertime(int[] attendence)
        {
            int overtimeHour = 0;
            for(int i=0; i< attendence.Length; i++)
            {
                if( attendence[i] > 8)
                {
                    overtimeHour++;
                }
            }
            return overtimeHour;
        }

        public int UpdateTotalHour(int todaysHour, int[] attendence)
        {
            int totalHour = 0;
            for (int i = 0; i < attendence.Length; i++)
            {
                totalHour += attendence[i];
            }
            return totalHour + todaysHour;
        }
    }

}
