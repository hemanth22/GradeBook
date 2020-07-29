using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Bitra's Grade Book");

            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' for quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            ///book.AddGrade(89.1);
            ///book.AddGrade(90.5);
            ///book.AddGrade(77.5);
            ////book.GetStatistics();

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"Grade Letter is {stats.Letter}");
        }
    }
}
