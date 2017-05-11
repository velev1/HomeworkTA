namespace Exceptions_homework
{
    using System;

    public class ExamResult
    {
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentException("The grade is positive integer number.");
            }

            if (minGrade < 0)
            {
                throw new ArgumentException("The minimum grade is positive integer number.");
            }

            if (maxGrade <= minGrade)
            {
                throw new ArgumentException("The maximum grade must be greater than the minimum grade.");
            }

            if (comments == null || comments == string.Empty)
            {
                throw new ArgumentException("The comment for the ExamResult cannot be null or empty");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade { get; private set; }

        public int MinGrade { get; private set; }

        public int MaxGrade { get; private set; }

        public string Comments { get; private set; }
    }
}
