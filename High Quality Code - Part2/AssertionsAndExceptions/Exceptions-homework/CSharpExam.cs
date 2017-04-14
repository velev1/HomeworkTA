namespace Exceptions_homework
{
    using System;

    public class CSharpExam : Exam
    {
        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ArgumentException("The score of the C sharp exam cannot be negative number");
            }

            this.Score = score;
        }

        public int Score { get; private set; }

        public override ExamResult Check()
        {
            if (this.Score > 100)
            {
                throw new ArgumentException("The result of the C sharp exam cannot be greater than 100 points.");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
