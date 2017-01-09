namespace Students_and_workers
{
    using System.Text;

    public class Student : Human , IStudent
    {
        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade { get; private set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append(string.Format("Student full name: {0} {1}",FirstName,LastName));
            str.Append(", grade: " + Grade);

            return str.ToString();
        }

    }
}
