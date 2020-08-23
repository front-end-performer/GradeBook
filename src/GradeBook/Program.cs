using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Oleksii's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(9.5);
            
            var stats =  book.GetStatistics();

                        
            Console.WriteLine($"The lowest grade is {stats.Low}"); 
            Console.WriteLine($"The highest grade is {stats.High}"); 
            Console.WriteLine($"The avarage grade is {stats.Average:N1}"); 
        }
    }
}
