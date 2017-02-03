namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private static int id = 10000;

        //the unique number is between 10000 and 99999.
        public int IdStudentGenerator()
        {
            id++;
            if (id >= 99999)
            {
                throw new ArgumentOutOfRangeException();
            }
            return id;
        }
    }
}
