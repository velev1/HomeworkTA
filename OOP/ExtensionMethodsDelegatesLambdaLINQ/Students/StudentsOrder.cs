namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentsOrder
    {
        public static IEnumerable<Student> OrderTheStudents(this List<Student> students)
        {
            var newStList = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            return newStList;
        }

        public static IEnumerable<Student> ShowStudentsByGroupNumber(this List<Student> students, int groupNumber)
        {
            var newList =
                from st in students
                where st.GroupNumber == groupNumber
                select st;
            if (newList == null || newList.Count()==0)
            {
                throw new ArgumentException("There are No such a group.");
            }
            return newList;
        }

        public static IEnumerable<Student> OrderStudentsByGroupNumber(this List<Student> students,int groupNumber)
        {


            var newList =
               from st in students
               where st.GroupNumber == groupNumber 
               select st;

            if (newList == null || newList.Count() == 0)
            {
                throw new ArgumentException("There are No such a group.");
            }

            newList =
                from st in newList
                orderby st.FirstName
                select st;

            return newList;
        }

        public static IEnumerable<Student> ExtractStudentByDomain(this List<Student> students, string domain)
        {
            var studentList =
                from st in students
                where st.Email.Substring(st.Email.LastIndexOf("@") + 1, (st.Email.Length - st.Email.LastIndexOf("@") - 1)) == domain
                select st;
            if (studentList == null || studentList.Count() == 0)
            {
                throw new ArgumentException(string.Format("There are No students with this domain -> {0}", domain));
            }
            return studentList;
        }
        public static IEnumerable<Student> ExtraxtByCityPhoneCode(this List<Student> students, string code)
        {
            
            var stList =
                from st in students
                where st.Tel.Substring(0, st.Tel.IndexOf("/")) == code
                select st;

            if (stList == null || stList.Count() == 0)
            {
                throw new ArgumentException(string.Format("There are No students with this city code number -> {0}", code));
            }

            return stList;
        }
    }
}
