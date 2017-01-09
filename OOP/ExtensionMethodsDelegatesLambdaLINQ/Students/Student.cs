namespace Students
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {

        public Student(string firstName, string lastName, int age, int fn, string tel, string email, List<int> marks, Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        //FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        // the age is used in the first problems of the homework.
        public int Age { get; private set; }

        public int FN { get; private set; }

        public string Tel { get; private set; }

        public string Email { get; private set; }

        public List<int> Marks { get; private set; }

        public Group GroupNumber { get; private set; }

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
            sb.Append("Age: " + Age + "\n");
            //FN, Tel, Email, Marks (a List), GroupNumber.
            sb.Append("FN: " + FN + "\n");
            sb.Append("Tel: " + Tel + "\n");
            sb.Append("E-mail: " + Email + "\n");
            sb.Append("Marks: " + string.Join(", ",Marks) + "\n");
            sb.Append("Group number: " + GroupNumber + "\n");
            sb.Insert(sb.Length, " . ", 12);

            return sb.ToString();
        }

      
    }
}
