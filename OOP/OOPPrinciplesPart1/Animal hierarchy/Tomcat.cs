namespace Animal_hierarchy
{
    using System;
    using Enums;

    public class Tomcat : Cat
    {
        private Gender animalGender;

        public Tomcat(string name, int age)
            :base(name, age)
        {
            this.AnimalGender = Gender.male;
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
            Console.WriteLine("I am Toooomm.");
        }
    }
}
