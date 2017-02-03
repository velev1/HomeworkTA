namespace School.Tests
{
    using System;
    using NUnit.Framework;

    using StudentsAndCourses;
    using StudentsAndCourses.CoursesEnum;

    [TestFixture]
    public class ScoolTests
    {
        [Test]
        public void SetName_WhenNameIsEmpty_ThrowsArgumentException()
        {

            Assert.Throws<ArgumentException>(() => new Student(""));
        }

        [Test]
        public void StudentIdGenerator_IfIdisInTheRange_TheIdIsValid()
        {
            //Arrange
            School sc = new School();

            //Act
            int result = sc.IdStudentGenerator();

            //Assert
            //the unique number is between 10000 and 99999.
            Assert.Greater(99999, result);
            Assert.Greater(result, 10000);
        }

        [TestCase(CourseName.algorithms)]
        [TestCase(CourseName.math)]
        [TestCase(CourseName.programming)]
        public void GetCountOfStudents_WhenCountGreaterThanUpperBound_DoNotAddStudent(CourseName courseName)
        {
            //Arrange
            Course c = new Course();
            //Act
            int result = c.GetCountOfStudents(courseName);
            //Assert
            Assert.LessOrEqual(result, 2);

        }

        [TestCase(CourseName.algorithms)]
        [TestCase(CourseName.math)]
        [TestCase(CourseName.programming)]
        public void AddStudentToCourse_AddingNewStudent_CountOfStudentsMustIncrement(CourseName courseName)
        {
            //Arrange
            Course c = new Course();
            //Act
            c.AddStudentToCourse(new Student("Pesho"), courseName);
            int result = c.GetCountOfStudents(courseName);
            //Assert
            Assert.AreEqual(1, result);
        }




    }
}
