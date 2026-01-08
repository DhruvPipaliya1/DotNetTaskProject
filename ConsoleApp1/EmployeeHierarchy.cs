using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class EmployeeHierarchy
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public int JoinYear { get; set; }
        public int Compensation { get; set; }
        public static int TotalEmployees { get; set; }


        public EmployeeHierarchy()
        {
            Name = "Unknown";
            Salary = 25000;
            Department = "General";
            JoinYear = 2024;

            calculateCompensation(); 
            TotalEmployees++;
        }

        public EmployeeHierarchy(string Name) : this()
        {
            if(Name.Length <= 2)
            {
                Name = "Unknown";
            }
            Name = Name;
        }

        public EmployeeHierarchy(string Name, int Salary) : this(Name)
        {
            if (Name.Length <= 2) {
                Name = "Unknown";
            }

            if (Salary < 20000)
            {
                Console.WriteLine($"Warning: Salary adjusted for Employee {Name} (was {Salary})");
                Salary = 25000;
            }

            else
            {
                Salary = Salary;
            }

            calculateCompensation();
        }

        public EmployeeHierarchy(string name, int salary, string department, int joinYear)
        {
            Name = name;
            Department = department;
            JoinYear = joinYear;

            if (salary < 20000)
            {
                Console.WriteLine($"Warning: Salary adjusted for {name} (was {salary})");
                Salary = 25000;
            }
            else
            {
                Salary = salary;
            }

            calculateCompensation();
            TotalEmployees++;
        }

        public void calculateCompensation() { 
            int compensation = Salary + (2024 - JoinYear) * 1000;
            Compensation = compensation;
        }
    }
}
