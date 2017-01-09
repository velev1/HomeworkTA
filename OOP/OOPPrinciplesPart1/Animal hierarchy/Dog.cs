namespace Animal_hierarchy
{
    using System;
    using Animal_hierarchy.Enums;

    public class Dog : Animal, ISound
    {
        private Gender animalGender;


        public Dog(string name, int age)
            : base(name, age)
        {

        }

        public Dog(string name, int age, Gender animalGender)
            : this(name, age)
        {
            this.AnimalGender = animalGender;
        }


        protected override Gender AnimalGender
        {
            get
            {
                return this.animalGender;
            }

            set
            {
                this.animalGender = value;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau!");
        }

    }
}
