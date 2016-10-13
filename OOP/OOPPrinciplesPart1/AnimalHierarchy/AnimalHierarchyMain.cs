
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalHierarchyMain
    {
        public static void Main()
        {
            // list of animals and method to add them
            List<Animal> animals = new List<Animal>();
            AddAnimals(animals);

            // finde the averege age of the animals and print it
            var averegeAge = animals.Average(x => (double)x.Age);
            Console.WriteLine(averegeAge);

            // print all animals to check the overriding of ToString() method
            animals.ForEach(x => Console.WriteLine(x));
        }

        private static void AddAnimals(List<Animal> collection)
        {
            collection.Add(new Kitten("Pena", 2));
            collection.Add(new Kitten("Cura", 3));
            collection.Add(new Kitten("Gena", 6));
            collection.Add(new Kitten("Temenuga", 1));
            collection.Add(new Tomcat("Pesho", 8));
            collection.Add(new Tomcat("Gosho", 10));
            collection.Add(new Tomcat("Kotio", 12));
            collection.Add(new Frog("Kermit", 1, Sex.Male));
            collection.Add(new Frog("Toti", 2, Sex.Female));
            collection.Add(new Frog("Frosty", 3, Sex.Male));
            collection.Add(new Dog("Doggy", 6, Sex.Male));
            collection.Add(new Dog("Laicho", 9, Sex.Male));
            collection.Add(new Dog("Raicho", 11, Sex.Male));
            collection.Add(new Cat("Maru", 3, Sex.Male));
            collection.Add(new Cat("Hamsiq", 5, Sex.Female));
            collection.Add(new Cat("Maca", 2, Sex.Female));
        }
    }
}
