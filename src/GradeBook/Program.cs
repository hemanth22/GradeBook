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
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5;
            book.ShowStatistics();
        }
    }
}
