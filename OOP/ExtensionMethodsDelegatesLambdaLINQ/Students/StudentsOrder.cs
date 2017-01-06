namespace Students
{
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentsOrder
    {
        public static IEnumerable<Student> OrderTheStudents(this List<Student> students)
        {
            var newStList = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            return newStList;
        }
    }
}
