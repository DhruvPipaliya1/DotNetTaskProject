using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class EmployeeAttendenceTracker
    {
        public (int totalHour, int overtimeHour) LoopCalculation(int[] attendence)
        {
            int totalHour = 0;
            int overtimeHour = 0;
            for (int i = 0; i < attendence.Length; i++)
            {
                totalHour += attendence[i];
                if (attendence[i] > 8)
                {
                    overtimeHour++;
                }
            }
            return (totalHour, overtimeHour);
        }

        public int CalculateTotalHour(int[] attendence)
        {
            var result = LoopCalculation(attendence);
            return result.totalHour;
        }

        public int CalculateOvertime(int[] attendence)
        {
            var result = LoopCalculation(attendence);
            return result.overtimeHour;
        }

        public int UpdateTotalHour(int todaysHour, int[] attendence)
        {
            var result = LoopCalculation(attendence);
            return result.totalHour + todaysHour;
        }
    }

}
