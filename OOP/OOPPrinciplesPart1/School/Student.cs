
namespace School
{
    using System.Text;

    public class Student : Person
    {

        private static int nextId = 0;
        private int id;
        private string comment;

        public Student(string name, string comment ="")
            :base(name)
        {
            this.id = ++nextId;
            this.Comment = comment;
        }

        public override string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Name + " ");
            str.Append("Id=" + Id);
            if (Comment !="")
            {
                str.Append(string.Format(" - comment: {0}", Comment));
            }

            return str.ToString(); 
        }

    }
}
