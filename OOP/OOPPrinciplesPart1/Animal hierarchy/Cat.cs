namespace Animal_hierarchy
{
    using Animal_hierarchy.Enums;

    public class Cat : Animal
    {
        private Gender animalGender;

        public Cat(string name, int age)
            :base(name,age)
        {

        }

        public Cat(string name, int age, Gender gender)
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
            System.Console.WriteLine("I am Cat.");
        }
    }
}
