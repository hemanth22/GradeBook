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
            var book = new InMemoryBook("Bitra's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);
            ///book.AddGrade(89.1);
            ///book.AddGrade(90.5);
            ///book.AddGrade(77.5);
            ////book.GetStatistics();

            var stats = book.GetStatistics();

            ///Console.WriteLine(Book.CATEGORY);
            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"Grade Letter is {stats.Letter}");
        }

        private static void EnterGrade(Book book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' for quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);

                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender,EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }

    }
}
