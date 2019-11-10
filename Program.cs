using System;
using System.Collections.Generic;

namespace BookGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book2  = null;
            if (book2 == null)
                Console.WriteLine("Null values detected");

            var book = new Book("Luis Grade Book");
            book.AddGrade(10.45);
            book.AddGrade(19);
            book.ShowStatistics();

            /*var grades = new List<double>() { 12.25, 15.5, 20.5 }; //This is an initialization expression.
            grades.Add(10);*/



        }
    }
}
