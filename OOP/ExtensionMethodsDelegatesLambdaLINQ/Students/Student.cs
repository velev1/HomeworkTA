namespace Students
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class  Student
    {

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public static IEnumerable<Student> FindAlphabeticOrder(List<Student> students)
        {
            var studentToFind = students.Where(s => s.FirstName.CompareTo(s.LastName) < 0);
                //from student in students
                //where student.FirstName.CompareTo(student.LastName) < 0
                //select student;

            return studentToFind;
        }

        public static IEnumerable<Student> AgeRange(List<Student> students)
        {
            var ageRange = students.Where(st => st.Age >= 18 && st.Age <= 24);
            //from student in students
            //where student.Age >= 18 && student.Age <= 24
            //select student;

            return ageRange;
        }

       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("First name: " + FirstName + "\n");
            sb.Append("last name: " + LastName + "\n");
            sb.Append("Age: " + Age);

            return sb.ToString();
        }
    }
}
