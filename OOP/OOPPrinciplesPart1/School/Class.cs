namespace School
{
    using System.Text;
    using System.Collections.Generic;

    using Enums;

    public class Class : IComment
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string comment;
        private Classes klas;

        public Class(List<Student> students, List<Teacher> teachers, Classes klas, string comment = "")
        {
            this.Students = students;
            this.Teachers = teachers;
            this.Klas = klas;
            this.Comment = comment;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }

        public string Comment
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

        public Classes Klas
        {
            get
            {
                return this.klas;
            }
            private set
            {
                this.klas = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(string.Format("This is klas: {0}\n", Klas));

            if (Comment != "")
            {
                str.Append(string.Format("Comment: {0}\n", Comment));
            }
            str.Append(string.Format("Students: {0}\n", string.Join(", ", Students)));
            str.Append(string.Format("Teachers: {0}\n", string.Join(", ", Teachers)));

            return str.ToString();
        }
    }
}
