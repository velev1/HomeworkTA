namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    public class Start
    {
        static void Main()
        {
            Student st1 = new Student("Zlatin", "Dimitrov", 23, 727306, "323/3223213", "zlatistiq@mail.bg", new List<int> { 5 },new Group(2,Departments.History));
            Student st4 = new Student("Ivan", "Petrov", 44, 332106, "434/3243243", "vankata@gmail.com", new List<int> { 6, 6, 5 },new Group(2,Departments.History));
            Student st2 = new Student("Pesho", "Petrov", 19, 555444, "02/975232323", "Pesho@abv.bg", new List<int> { 4, 3 },new Group(4,Departments.Matematics));
            Student st3 = new Student("Borislav", "Angelov", 25, 666333, "02/955343434", "Bobi@abv.bg", new List<int> { 5, 6 }, new Group(3, Departments.Science));
            Student st5 = new Student("Georgi", "Ivanov", 24, 635906, "02/977498322", "gosho_hubaveca@abv.bg", new List<int> { 6, 6 }, new Group(4, Departments.Matematics));


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
            Console.WriteLine("=======================================");
            //Create a List<Student> with sample students. Select only the students that are from group number 2.
            Console.WriteLine("The student in the Group with number 2.");
            Console.WriteLine("---------------------------------------");
            var groupTwo = students.Where(st => st.GroupNumber == 2);
            foreach (var item in groupTwo)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("=====================================================================");
            var orderGroupTwo =
                from st in groupTwo
                orderby (st.FirstName)
                select st;
            Console.WriteLine("The group with number 2 is now ordered by first name of the students.");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var item in orderGroupTwo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("=============================================");
            var grouped = StudentsOrder.ShowStudentsByGroupNumber(students, 4);
            Console.WriteLine("Group by group number using extension method.");
            Console.WriteLine("---------------------------------------------");
            foreach (var item in grouped)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("=========================================================");
            Console.WriteLine("Group by group number then by first name using ex method.");
            Console.WriteLine("---------------------------------------------------------");
            grouped = StudentsOrder.OrderStudentsByGroupNumber(students, 4);
            foreach (var item in grouped)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("======================================================");
            Console.WriteLine("Extract student with email in abv.bg or onather one...");
            Console.WriteLine("------------------------------------------------------");
            var byMail = StudentsOrder.ExtractStudentByDomain(students, "abv.bg");
            foreach (var item in byMail)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("Select the student with Phone number in Sofia \"02\"");
            Console.WriteLine("----------------------------------------------------");
            var byPhoneCode = StudentsOrder.ExtraxtByCityPhoneCode(students, "02");

            foreach (var item in byPhoneCode)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("========================================");
            Console.WriteLine("Extract student with mark excellent (6) ");
            Console.WriteLine("----------------------------------------");

            var excellents = (
                from st in students
                where st.Marks.Contains(6)
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                }).ToList();

            excellents.ForEach(st => Console.WriteLine("{0} - {1}", st.FullName, string.Join(", ", st.Marks)));

            Console.WriteLine("========================");
            Console.WriteLine("Students with two marks.");
            Console.WriteLine("------------------------");

            var twoMarks = (
                from st in students
                where st.Marks.Count == 2
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                }).ToList();

            twoMarks.ForEach(st => Console.WriteLine("{0} - {1}", st.FullName, string.Join(", ", st.Marks)));

            Console.WriteLine("========================================================");
            Console.WriteLine("Extract all Marks of the students that enrolled in 2006.");
            Console.WriteLine("--------------------------------------------------------");
            var marksIn2006 = (
                from st in students
                where (st.FN / 10) % 10 == 0 && st.FN % 10 == 6
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                }).ToList();

            marksIn2006.ForEach(st => Console.WriteLine("{0} - {1}", st.FullName, string.Join(", ", st.Marks)));

            //Console.WriteLine("=========================gr");

            //var grouedByGroupNumber = (
            //    from st in students
            //    orderby st.Group.GroupNumber
            //    group st by st.Group.GroupNumber
            //    into groups
            //    select new
            //    {
            //        Group = groups.Key,
            //        Students = groups.ToList()
            //    })
            //    .ToList();

        }
    }
}
