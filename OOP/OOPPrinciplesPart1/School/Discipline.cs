namespace School
{
    using System;
    using System.Text;

    public class Discipline : IComment
    {
        private string comment;

        public Discipline(string name, int numOfLectures, int numOfEx, string comment = "")
        {
            this.Name = name;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfEx;
            this.Comment = comment;
        }

        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }

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

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (Comment != "")
            {
                str.Append(string.Format(" (discipline:{0} Lectures:{1} Exercises:{2} comment:{3})"
                    , Name, NumberOfLectures, NumberOfExercises,Comment));
            }
            else
            {
                str.Append(string.Format(" (discipline:{0} Lectures:{1} Exercises:{2})"
                    , Name, NumberOfLectures, NumberOfExercises));

            }

            return str.ToString();
        }

    }
}
