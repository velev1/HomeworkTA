namespace Animal_hierarchy
{
    using System;
    using System.Text;
    using Animal_hierarchy.Enums;

    public abstract class Animal : ISound
    {

        private string name;

        private int age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

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
                    throw new ArgumentException("The name of the animal can NOT be empty");
                }
                this.name = value;
            }
        }


        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("The age must be possitive and greater than zero number.");
                }
                this.age = value;
            }
        }

        protected abstract Gender AnimalGender { get; set; }

        

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append(string.Format("Name: {0}, age: {1}, Gender: {2}", Name, Age, AnimalGender));
            return str.ToString();
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal ...");
        }
    }
}
