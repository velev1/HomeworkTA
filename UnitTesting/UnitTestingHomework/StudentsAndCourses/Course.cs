
namespace StudentsAndCourses
{

    using System.Collections.Generic;

    using CoursesEnum;


    public class Course
    {
        private ICollection<Student> programmingList;
        private ICollection<Student> mathList;
        private ICollection<Student> algorithms;

        public Course()
        {
            programmingList = new List<Student>();
            mathList = new List<Student>();
            algorithms = new List<Student>();

           

            //AddStudentToCourse(new Student("Pesho"), CourseName.math);
            //AddStudentToCourse(new Student("Ivan"), CourseName.math);
            //AddStudentToCourse(new Student("Dragan"), CourseName.math);


        }



        public void AddStudentToCourse(Student student, CourseName course)
        {
            switch (course)
            {
                case CourseName.programming:
                    if (GetCountOfStudents(CourseName.programming) < 30)
                    {
                        programmingList.Add(student);
                    }
                    break;
                case CourseName.math:
                    if (GetCountOfStudents(CourseName.math) < 30)
                    {
                        mathList.Add(student);
                    }
                    break;
                case CourseName.algorithms:
                    if (GetCountOfStudents(CourseName.algorithms) < 30)
                    {
                        algorithms.Add(student);
                    }
                    break;
            }
        }

        public void RemoveStudentFromCourse(Student student, CourseName course)
        {
            switch (course)
            {
                case CourseName.programming:
                    programmingList.Remove(student);
                    break;
                case CourseName.math:
                    mathList.Remove(student);
                    break;
                case CourseName.algorithms:
                    algorithms.Remove(student);
                    break;
            }

        }

        public int GetCountOfStudents(CourseName course)
        {
            int count = 0;
            switch (course)
            {
                case CourseName.programming:
                    count = programmingList.Count;
                    break;
                case CourseName.math:
                    count = mathList.Count;
                    break;
                case CourseName.algorithms:
                    count = algorithms.Count;
                    break;
            }

            return count;
        }
    }
}
