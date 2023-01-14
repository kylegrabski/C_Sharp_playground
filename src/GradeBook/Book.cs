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
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0; // We do NOT need to instantiate field declarations. The C# runtime sets it all to 'All Bits Off'.
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        // Field declaration
        private List<double> grades;
        public string Name; // public member has capital letter

        public List<double> duhGrades => grades;

        public string bookName => Name != null ? Name : "NA";
    }
}
