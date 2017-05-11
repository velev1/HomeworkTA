namespace Exceptions_homework
{
    using System;

    using Enums;

    public class SimpleMathExam : Exam
    {
        public SimpleMathExam(MathProblemSolved problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public MathProblemSolved ProblemsSolved { get; private set; }

        public override ExamResult Check()
        {
            switch (this.ProblemsSolved)
            {
                case MathProblemSolved.Bad:
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");

                case MathProblemSolved.Average:
                    return new ExamResult(4, 2, 6, "Average result: half of the problems done.");

                case MathProblemSolved.Excellent:
                    return new ExamResult(6, 2, 6, "Excellent result: everething done.");

                default:
                    throw new ArgumentException("The result can be only BAD, AVERAGE and EXCELLENT");
            }
        }
    }
}
