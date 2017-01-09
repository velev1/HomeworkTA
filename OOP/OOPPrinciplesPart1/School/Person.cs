
namespace School
{

    public abstract class Person : IComment
    {
        public string Name { get; private set; }

        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public abstract string Comment { get; set; }
    }
}
