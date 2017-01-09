namespace Students_and_workers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Start
    {
        static void Main()
        {
            IStudent st1 = new Student("Ivan", "Petrov", 3);
            IStudent st2 = new Student("Georgi", "Geshev", 5);
            IStudent st3 = new Student("Haralampi", "Ivanov", 2);
            IStudent st4 = new Student("Ivan", "Dimitrov", 3);
            IStudent st5 = new Student("Darina", "Petrova", 6);
            IStudent st6 = new Student("Hristina", "Ivanova", 6);
            IStudent st7 = new Student("Iliya", "Nikolov", 5);
            IStudent st8 = new Student("Nikola", "Iliev", 4);
            IStudent st9 = new Student("Petyr", "Jelev", 4);
            IStudent st10 = new Student("Dona", "Stefanova", 5);

            List<IStudent> students = new List<IStudent>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);
            students.Add(st6);
            students.Add(st7);
            students.Add(st8);
            students.Add(st9);
            students.Add(st10);
         

            Console.WriteLine("The students sorted by grade in ascending order.");
            Console.WriteLine("================================================");
            var sortedStudents =
             from st in students
             orderby st.Grade
             select st;
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------");

            IWorker w1 = new Worker("Doncho","Byrdarov",100m,8);
            IWorker w2 = new Worker("Cvetelina","Gesheva",200m,8);
            IWorker w3= new Worker("Sonia","Stoikova",300m,9);
            IWorker w4 = new Worker("Pesho","Petrov",150m,6);
            IWorker w5 = new Worker("Slaveiko","Slavchev",220m,8);
            IWorker w6 = new Worker("Joro","Bicepsa",290m,7);
            IWorker w7 = new Worker("Gosho","Velev",240m,7);
            IWorker w8 = new Worker("Stefan","Angelov",333m,8);
            IWorker w9 = new Worker("Valentin","Zlatev",444m,7);
            IWorker w10 = new Worker("Ivo","Hakera",445m,6);
            List<IWorker> workers = new List<IWorker>();
            workers.Add(w1);
            workers.Add(w2);
            workers.Add(w3);
            workers.Add(w4);
            workers.Add(w5);
            workers.Add(w6);
            workers.Add(w7);
            workers.Add(w8);
            workers.Add(w9);
            workers.Add(w10);

            Console.WriteLine("Workers sorted by by money per hour in descending order.");
            Console.WriteLine("======================================================================");

            var sortedWorkers =
                from w in workers
                orderby w.MoneyPerHour() descending
                select w;

            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            //Merge students and workers
            List<Human> humans = new List<Human>();
            for (int i = 0; i < students.Count; i++)
            {
                humans.Add((Student)students[i]);
                humans.Add((Worker)workers[i]);
            }

            Console.WriteLine("The people sorted by first name and last name.");
            Console.WriteLine("===========================================================================");

            var sortedPeople =
                from p in humans
                orderby p.FirstName, p.LastName
                select p;

            foreach (var item in sortedPeople)
            {
                Console.WriteLine(item);
            }
        }
    }
}
