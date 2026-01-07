// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

namespace project
{
    class Program {
        public static void Main(string[] args)
        {

            //int[] temperature = { 22, 35, 18, 40, 28 };
            //var TempAnalyzer = new TemperatureAnalyzer();
            //Console.WriteLine("Hot Days: " + TempAnalyzer.CalculateHotDays(temperature));
            //Console.WriteLine("Average Temperature: " + TempAnalyzer.AverageTemperature(temperature));
            //Console.Write("Enter Temperature: ");
            //int CurrentTemp = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Category: " + TempAnalyzer.CategorizeTemperature(CurrentTemp));



            //int[] attendence = { 8, 6, 9, 5, 10 };
            //var AttendenceTracker = new EmployeeAttendenceTracker();
            //Console.WriteLine("Total hours: " + AttendenceTracker.CalculateTotalHour(attendence));
            //Console.WriteLine("Overtime Days: " + AttendenceTracker.CalculateOvertime(attendence));
            //Console.Write("Enter today's hours: ");
            //int todaysHour = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Updated hour: " + AttendenceTracker.UpdateTotalHour(todaysHour, attendence));



            //int[] parkHour = {2, 5, 1, 8, 3};
            //var ParkCalculator = new ParkingFeeCalculator();
            //Console.WriteLine("Total Fee: " + ParkCalculator.TotalParkingFee(parkHour));
            //Console.WriteLine("Full Day Parkers: " + ParkCalculator.CalculateFullDaysParkers(parkHour));
            //Console.Write("Enter Parking Hours: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Fee: " + ParkCalculator.UserParkingFee(userInput));



            //int[] stocks = { 50, 5, 25, 0, 15 };
            //var CalculateStock = new InventoryStockCheck();
            //Console.WriteLine("Out of Stock: " + CalculateStock.CalculateOutOfStockItems(stocks));
            //Console.WriteLine("Low Stock items: " + CalculateStock.CalculateLowStockItems(stocks));
            //Console.Write("Enter item number (0-4): ");
            //int stockNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter restock quantity: ");
            //int stockQuantity = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("New Quantity: " + CalculateStock.AddNewItem(stockNumber, stockQuantity, stocks));



            //int[] units = { 150, 200, 180, 220, 160 };
            //var ElectricityBill = new ElectricityBillCalculator();
            //Console.WriteLine("Total Units: " + ElectricityBill.TotalElectricityUnits(units));
            //Console.WriteLine("High Usage Months: " + ElectricityBill.HighUsageMonthsCount(units));
            //Console.Write("Enter Current Usage: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Bill: " + ElectricityBill.CurrentUsage(userInput, units));




            //int[] number = { 4, 5, 6 };
            //var CalculateFactorial = new NumberFactorialCalculator();
            //for(int i=0; i<number.Length; i++)
            //{
            //    Console.WriteLine($"{number[i]}! = {CalculateFactorial.FindFactorial(number[i])}");
            //}
            //Console.Write("Enter a Number: ");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{userInput}! = {CalculateFactorial.FindFactorial(userInput)}");




            //string[] strs = { "hello", "world", "code" };
            //var StringReversal = new StringReversalTree();
            //for(int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine($"{strs[i]} => " + StringReversal.ReverseString(strs[i]));
            //}
            //Console.Write("Enter a string: ");
            //string userInput = Console.ReadLine();
            //Console.WriteLine($"{userInput} => " + StringReversal.ReverseString(userInput
            //




            //var students = new List<StudentGradeManage>
            //{
            //    new StudentGradeManage{ Id = "S01", Name = "Alice Johnson", Grades=new(){ ["Math"]=95, ["Eng"]=88, ["Sci"]=92, ["Art"]=88} },
            //    new StudentGradeManage{ Id = "S02", Name = "Bob Smith", Grades=new(){ ["Math"]=78, ["Eng"]=82, ["Sci"]=75, ["Art"]=90} },
            //    new StudentGradeManage{ Id = "S03", Name = "Carol Davis", Grades=new(){ ["Math"]=88, ["Eng"]=95, ["Sci"]=91, ["Art"]=87} },
            //    new StudentGradeManage{ Id = "S04", Name = "David Wilson", Grades=new(){ ["Math"]=65, ["Eng"]=70, ["Sci"]=68, ["Art"]=72} },
            //    new StudentGradeManage{ Id = "S05", Name = "Emma Brown", Grades=new(){ ["Math"]=92, ["Eng"]=89, ["Sci"]=94, ["Art"]=88} },
            //    new StudentGradeManage{ Id = "S06", Name = "Frank Miller", Grades=new(){ ["Math"]=58, ["Eng"]=62, ["Sci"]=60, ["Art"]=65} },
            //    new StudentGradeManage{ Id = "S07", Name = "Grace Lee", Grades=new(){ ["Math"]=85, ["Eng"]=91, ["Sci"]=87, ["Art"]=93} },
            //    new StudentGradeManage{ Id = "S08", Name = "Henry Clark", Grades=new(){ ["Math"]=72, ["Eng"]=75, ["Sci"]=78, ["Art"]=70} },
            //};

            //GradeCalculator standard = GradeCalculations.Standard;
            //GradeCalculator weighted = GradeCalculations.Weighted;
            //GradeCalculator bonus = GradeCalculations.Bonus;

            //foreach(var s in students)
            //{
            //    double std = standard(s);
            //    double wtd = weighted(s);
            //    Console.WriteLine($"{s.Name}: Standard={std:F2} Weighted={wtd:F2} -> Difference={wtd - std:F2}");
            //}

            //Func<StudentGradeManage, bool> highPerformer = s => standard(s) > 85;
            //Func<StudentGradeManage, bool> allSubjects = s => s.Grades.Values.All(g => g > 80);
            //Func<StudentGradeManage, bool> atRisk = s => s.Grades.Values.Any(g => g < 65);


            //Console.WriteLine("\nHigh Performers");
            //students.Where(highPerformer)
            //    .ToList()
            //    .ForEach(s => Console.WriteLine($"{s.Name} ({standard(s)})"));

            //Console.WriteLine("\nHonor Roll");
            //students.Where(allSubjects)
            //    .ToList()
            //    .ForEach(s => Console.WriteLine($"{s.Name} (all>80)"));

            //Console.WriteLine("\nAt Risk");
            //students.Where(atRisk)
            //    .ToList()
            //    .ForEach(s => Console.WriteLine($"{s.Name}"));

            //var res = students.GroupBy(e =>
            //{
            //    double avg = standard(e);
            //    if (avg >= 90) return "A";
            //    else if (avg >= 80) return "B";
            //    else if (avg >= 70) return "C";
            //    else if (avg >= 60) return "D";
            //    return "F";
            //});
            
            //foreach(var group in res)
            //{
            //    Console.WriteLine($"\nGrade {group.Key}");
            //    foreach(var s in group)
            //    {
            //        Console.WriteLine($"{s.Name} ({standard(s):F2})");
            //    }
            //}

            //Console.WriteLine("\n\nCourse Statistics:");
            //var courses = new[] { "Math", "Eng", "Sci", "Art" };

            //foreach(var course in courses)
            //{
            //    var courseGrades = students.Select(s => new
            //    {
            //        s.Name,
            //        Grade = s.Grades[course]
            //    });

            //    Console.WriteLine($"\n{course} Course Performance:");
            //    Console.WriteLine($"Average: {courseGrades.Average(g => g.Grade):F2}");
            //    Console.WriteLine($"Highest: {courseGrades.Max(g => g.Grade):F2}");
            //    Console.WriteLine($"Lowest: {courseGrades.Min(g => g.Grade):F2}");
            //    Console.WriteLine($"Students above average: {courseGrades.Count(g => g.Grade > courseGrades.Average(x => x.Grade))}");



            //    Console.WriteLine("\nMethod Chaining Result:");
            //    students.Where(s => standard(s) > 80)
            //            .OrderByDescending(s => standard(s))
            //            .Select(s => new { s.Name, Avg = standard(s) })
            //            .ToList()
            //            .ForEach(x => Console.WriteLine($"{x.Name} ({x.Avg:F2})"));




            }

        }
    }

}