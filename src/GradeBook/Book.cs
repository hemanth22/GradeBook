using System;
using System.Collections.Generic;
namespace GradeBook
{
public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index=0; index < grades.Count; index++)
            {
                if (grades[index] == 42.1)
                {
                    goto done;
                }
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;
            done:
            return result;    
        }

        private List<double> grades;
        public string Name;
    }
}