namespace Exceptions_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (exams == null)
            {
                exams = new List<Exam>();
            }

            if (firstName == null || firstName == string.Empty)
            {
                throw new ArgumentException("The first name cannot be null or empty.");
            }

            if (lastName == null || lastName == string.Empty)
            {
                throw new ArgumentException("The last name cannot be null or empty.");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<Exam> Exams { get; set; }

        public IList<ExamResult> CheckExams()
        {
            IList<ExamResult> results = new List<ExamResult>();

            if (this.Exams == null)
            {
                throw new ArgumentNullException("The list with exams of the student are not initialized");
            }
            else if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!");
            }
            else
            {
                for (int i = 0; i < this.Exams.Count; i++)
                {
                    results.Add(this.Exams[i].Check());
                }
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException("Cannot calculate the average result. The list of exams of the studen is not initialized");
            }
            else if (this.Exams.Count == 0)
            {
                // No exams --> return 0;
                return 0;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
