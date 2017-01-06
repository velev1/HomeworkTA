namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    

    public class Start
    {  
        static void Main()
        {
            Student st1 = new Student("Ivan", "Petrov", 44);
            Student st2 = new Student("Radko", "Simeonov", 20);
            Student st3 = new Student("Borislav", "Angelov", 25);
            Student st4 = new Student("Zlatin", "Dimitrov", 23);
            Student st5 = new Student("Georgi", "Ivanov", 24);

            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);

            var newList = Student.FindAlphabeticOrder(students);
            Console.WriteLine("students whose first name is before its last name alphabetically.");
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (var student in newList)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("============================================");


            var ageRange = Student.AgeRange(students);
            Console.WriteLine("Student who are between 18 and 24 years old.");
            Console.WriteLine("--------------------------------------------");
            foreach (var item in ageRange)
            {
                Console.WriteLine(item.ToString()); 
            }
            Console.WriteLine("===============================================================================");

            var orderedListOfStudentDescending = StudentsOrder.OrderTheStudents(students);
            Console.WriteLine("The student are now orderd by first name then by last name in descending order.");
            Console.WriteLine("-------------------------------------------------------------------------------");
            foreach (var item in orderedListOfStudentDescending)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
