using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    delegate double GradeCalculator(StudentGradeManage student);
    public class StudentGradeManage
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Dictionary<string, int> Grades { get; set; }
    }

    public class Course
    {
        public string Name { get; set; }  
    }

    public class GradeCalculations
    {
        public static double Standard(StudentGradeManage student) { 
            return student.Grades.Values.Average();
        }

        public static double Weighted(StudentGradeManage student)
        {
            return (student.Grades["Math"] * 0.4) + (student.Grades["Eng"] * 0.3) + (student.Grades["Sci"] * 0.2) + (student.Grades["Art"] * 0.1);
        }

        public static double Bonus(StudentGradeManage student) {
            double avg = Standard(student);
            if (avg >= 90)
                avg += avg * 0.05;
            return avg;
        }
    }
}
