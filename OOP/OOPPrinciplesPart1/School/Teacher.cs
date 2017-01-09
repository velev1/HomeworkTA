namespace School
{
    using System.Text;

    public class Teacher : Person
    {
        private string comment;

        public Teacher(string name, Discipline discipline ,string comment = "")
            :base(name)
        {
            this.Comment = comment;
            this.Disc = discipline;
        }

        public Discipline Disc { get; private set; }

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


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            
            str.Append(Name);
            str.Append(Disc);
            if (Comment != "")
            {
                str.Append(string.Format(" - comment: {0}", Comment));
            }

            return str.ToString();
        }
    }
}
