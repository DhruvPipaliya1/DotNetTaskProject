namespace ConsoleApp1
{
    internal class ElectricityBillCalculator
    {
        public (int totalUnits, int HighUsageMonths) CalculateTotalUnites(int[] units)
        {
            int totalUnits = 0;
            int HighUsageMonths = 0;
            for (int i=0; i< units.Length; i++) {
                totalUnits += units[i];
                if (units[i] > 180) {
                    HighUsageMonths++;
                }
            }
            return (totalUnits, HighUsageMonths);
        }

        public int TotalElectricityUnits(int[] units)
        {
            var result = CalculateTotalUnites(units);
            return result.totalUnits;
        }

        public int HighUsageMonthsCount(int[] units)
        {
            var result = CalculateTotalUnites(units);
            return result.HighUsageMonths;
        }

        public int CurrentUsage(int currentMonthUnits, int[] units)
        {
            return currentMonthUnits * 5 + 50;
        }
    }
}
