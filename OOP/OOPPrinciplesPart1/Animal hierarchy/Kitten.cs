namespace Animal_hierarchy
{
    using System;
    using Enums;

    public class Kitten : Cat , ISound
    {
        private Gender animaGender;

        public Kitten(string name, int age)
            :base(name,age)
        {
            this.AnimalGender = Gender.female;
        }

        protected override Gender AnimalGender
        {
            get
            {
                return this.animaGender;
            }
            set
            {
                this.animaGender = value;
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("I am Kitten.");
        }
    }
}
