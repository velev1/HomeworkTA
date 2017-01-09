namespace School
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public class Start
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            Student st1 = new Student("Pesho","The best hahahah");
            Student st2 = new Student("Gosho");
            Student st3 = new Student("Tosho");
            Student st4 = new Student("Ganio","Hello !");
            Student st5 = new Student("Blagoi");

            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);

            List<Student> stud1 = new List<Student>();
            stud1.Add(st5);
            stud1.Add(st4);
            stud1.Add(st1);

            List<Student> stud2 = new List<Student>();
            stud2.Add(st2);
            stud2.Add(st3);



            Console.WriteLine("==============================");
            Console.WriteLine("All students:");
            Console.WriteLine("==============================");


            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Teacher t1 = new Teacher("Ivan",new Discipline("History,",10,11), "knowedge is power!");
            Teacher t2 = new Teacher("Georgi", new Discipline("Geography,", 7, 10));
            Teacher t3 = new Teacher("Cvetelina", new Discipline("Mathematics,", 15, 15, "very hard!"));
            Teacher t4 = new Teacher("Gruio", new Discipline("Chemistry,", 10, 15), "gruh, gruh");

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(t1);
            teachers.Add(t2);
            teachers.Add(t3);
            teachers.Add(t4);
            List<Teacher> tech1 = new List<Teacher>();
            tech1.Add(t1);
            tech1.Add(t2);
            List<Teacher> tech2 = new List<Teacher>();
            tech2.Add(t3);
            tech2.Add(t4);

            
            Console.WriteLine("==============================");
            Console.WriteLine("All teachers:");
            Console.WriteLine("==============================");

            foreach (var item in teachers)
            {
                Console.WriteLine(item.ToString());
            }

            Class firstKlas = new Class(stud1, tech1, Classes.A,"Some comment");
            Class secondKlas = new Class(stud2, tech2, Classes.B);
            Console.WriteLine("==================================================");
            Console.WriteLine(firstKlas.ToString());
            Console.WriteLine("==================================================");
            Console.WriteLine(secondKlas.ToString());


        }
    }
}
