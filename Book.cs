using System;
using System.Collections.Generic;
using System.Text;

namespace BookGrade
{
    class Book
    {
        // Explicit constructor:
        public Book(string name)
        {
            // Initialization of the field named grades
            // Always be initialized
            grades = new List<double>();
            this.name = name;
        }    

        //Instant method
        public void AddGrade(double grade)
        {
            grades.Add(grade);  
        }
        public void ShowStatistics()
        {
            var result = 0.0;
            var HighGrade = double.MinValue;
            var LowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                HighGrade = Math.Max(HighGrade, number);
                LowGrade = Math.Min(LowGrade, number);
                result += number;
            }
            result /= grades.Count;
            // Console class has static method WriteLine
            Console.WriteLine($"Average: {result:N2}");
            Console.WriteLine($"Highest Grade: {HighGrade:N2}");
            Console.WriteLine($"Lowest Grade: {LowGrade:N2}");
        }

        // (Instant) Field named grades
        private List<double> grades;
        private string name;
    }
}
