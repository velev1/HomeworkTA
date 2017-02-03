
namespace StudentsAndCourses
{

    using System;

    using CoursesEnum;

    public class Student
    {
        private string name;

       
        //Name can not be empty and 
        public Student(string name)
        {
            this.Name = name;
            School sc = new School();
            this.StudentId = sc.IdStudentGenerator();
        }

        public int StudentId { get; private set; } 

        public string Name
        {
            get
            {
                return this.name;

            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public void JoinCourse(Student student, CourseName course)
        {
            Course c = new Course();
            c.AddStudentToCourse(student, course);
        }

        public void LeaveCourse(Student student, CourseName course)
        {
            Course c = new Course();
            c.RemoveStudentFromCourse(student, course);
        }
        
    }
}
