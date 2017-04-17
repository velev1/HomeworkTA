namespace Exceptions_homework
{
    using System;
    using System.Collections.Generic;

    using Enums;

    public class ExceptionsHomework
    {
        public static void Main()
        {
            Utils worker = new Utils();

            var substr = Utils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(Utils.ExtractEnding("I love C#", 2));
            Console.WriteLine(Utils.ExtractEnding("Nakov", 4));
            Console.WriteLine(Utils.ExtractEnding("beer", 4));
            Console.WriteLine(Utils.ExtractEnding("Hi", 100));

            int number = 23;

            // if uncomment next line will catch the Exception
            // number = 33;
            try
            {
                Utils.CheckPrime(number);
                Console.WriteLine("{0} is prime.", number);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(MathProblemSolved.Bad),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(MathProblemSolved.Excellent),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
