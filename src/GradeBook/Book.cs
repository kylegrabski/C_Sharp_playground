using System.Collections.Generic;

namespace GradeBook
{
    // No access modifier given, defaults to 'internal'. Meaning it can ONLY be used within the same project.
    public class Book
    {
        // Constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                System.Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0; // We do NOT need to instantiate field declarations. The C# runtime sets it all to 'All Bits Off'.
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            // foreach (var grade in grades)
            // {
            //     result.Low = Math.Min(grade, result.Low);
            //     result.High = Math.Max(grade, result.High);
            //     result.Average += grade;
            // }

            for (int i = 0; i < grades.Count; i++)
            {
                result.Low = Math.Min(grades[i], result.Low);
                result.High = Math.Max(grades[i], result.High);
                result.Average += grades[i];
            }

            result.Average /= grades.Count;

            return result;
        }

        public List<double> GetGrades()
        {
            return grades;
        }

        // Field declaration
        private List<double> grades;
        public string Name; // public member has capital letter

        public List<double> duhGrades => grades;

        public string bookName => Name != null ? Name : "NA";
    }
}
