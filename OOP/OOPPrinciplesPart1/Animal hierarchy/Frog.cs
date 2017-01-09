namespace Animal_hierarchy
{
    using System;
    using Animal_hierarchy.Enums;

    public class Frog : Animal, ISound
    {
        private Gender animalGender;

        public Frog(string name, int age)
            :base(name, age)
        {

        }

        public Frog(string name, int age, Gender gender)
            :this(name,age)
        {
            this.AnimalGender = gender;
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
            Console.WriteLine("Kwa, kwa");
        }
    }
}
