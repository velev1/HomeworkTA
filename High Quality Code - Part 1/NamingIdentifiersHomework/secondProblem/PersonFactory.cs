namespace secondProblem
{
    using Enums;

    public class PersonFactory
    {
        // I know that this method make no sense but the task is "naming" so.. 
        public void CreatePerson(int number)
        {
            Person person = new Person();
            person.Age = number;

            if (number % 2 == 0)
            {
                person.Name = "Pesho";
                person.GenderType = Gender.Male;
            }
            else
            {
                person.Name = "Penka";
                person.GenderType = Gender.Female;
            }
        }
    }
}
