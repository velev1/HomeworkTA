namespace Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Start
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            AddAnimals(animals);

            Console.WriteLine("All animals.");
            Console.WriteLine("=================================================");
            foreach (var item in animals)
            {
                Type t = item.GetType();
                Console.WriteLine(t.Name + " " +item);
            }
            Console.WriteLine("==================================================");

            var avgAgeDogs =
                (from d in animals
                where d is Dog
                select d).Average(x => x.Age);
            Console.WriteLine("The average age of Dogs: {0:F2}", avgAgeDogs);

            Console.WriteLine("-------------------------------------------------");
            var avgAgeCats =
                (from c in animals
                 where c is Cat
                 select c).Average(x => x.Age);
            Console.WriteLine("The average age of Cats: {0:F2}", avgAgeCats);

            Console.WriteLine("-------------------------------------------------");
            var avgAgeToms =
                (from t in animals
                 where t is Tomcat
                 select t).Average(x => x.Age);

            Console.WriteLine("The average age of Tomcats: {0:F2}", avgAgeToms);

            Console.WriteLine("-------------------------------------------------");
            var avgAgeKittens =
                (from k in animals
                 where k is Kitten
                 select k).Average(x => x.Age);


            Console.WriteLine("The average age of Kittens: {0:F2}", avgAgeKittens);

            Console.WriteLine("-------------------------------------------------");

            var avgAgeFrogs =
                (from f in animals
                 where f is Frog
                 select f).Average(x => x.Age);

            Console.WriteLine("The average age of Frogs: {0:F2}", avgAgeFrogs);
            Console.WriteLine("-------------------------------------------------");




        }

        public static List<Animal> AddAnimals(List<Animal> animals)
        {
            //some dogs
            Dog d1 = new Dog("Sharo", 2, Enums.Gender.male);
            Dog d2 = new Dog("Murjo", 7, Enums.Gender.male);
            Dog d3 = new Dog("Tara", 4, Enums.Gender.female);
            //some cats
            Cat c1 = new Cat("Pisana", 3, Enums.Gender.female);
            Cat c2 = new Cat("Puhcho", 4, Enums.Gender.male);
            Cat c3 = new Cat("Chernio", 1, Enums.Gender.male);
            //some Tom
            Tomcat t1 = new Tomcat("Tomi", 2);
            Tomcat t2 = new Tomcat("Riki", 3);
            Tomcat t3 = new Tomcat("The Big Tomi", 5);
            //some Kittens
            Kitten k1 = new Kitten("Rijka", 1);
            Kitten k2 = new Kitten("Rumi", 2);
            Kitten k3 = new Kitten("Maca", 1);
            //frogs
            Frog f1 = new Frog("Krastawata", 2, Enums.Gender.female);
            Frog f2 = new Frog("Groznata", 5, Enums.Gender.female);
            Frog f3 = new Frog("Maznio", 3, Enums.Gender.male);
            animals.Add(d1);
            animals.Add(d2);
            animals.Add(d3);
            animals.Add(c1);
            animals.Add(c2);
            animals.Add(c3);
            animals.Add(t1);
            animals.Add(t2);
            animals.Add(t3);
            animals.Add(k1);
            animals.Add(k2);
            animals.Add(k3);
            animals.Add(f1);
            animals.Add(f2);
            animals.Add(f3);
            return animals;
        }
    }
}
