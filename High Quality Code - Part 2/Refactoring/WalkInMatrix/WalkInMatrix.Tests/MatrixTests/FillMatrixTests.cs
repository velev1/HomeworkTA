namespace WalkInMatrix.Tests.MatrixTests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class FillMatrixTests
    {

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        public void PassingNumberLessThanTwo_ThrowsArgumentException(int number)
        {
            Matrix matrix = new Matrix();

            Assert.Throws<ArgumentException>(() => matrix.FillMatrix(number));
        }
    }
}
