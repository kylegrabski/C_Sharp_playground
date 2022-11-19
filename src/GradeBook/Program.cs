using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kyle's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();

            System.Console.WriteLine($"the book name IS {book.bookName}");

            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The average grade is {stats.Average}");
        }
    }
}
