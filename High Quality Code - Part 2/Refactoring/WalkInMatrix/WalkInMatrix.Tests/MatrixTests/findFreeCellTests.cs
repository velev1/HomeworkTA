namespace WalkInMatrix.Tests.MatrixTests
{
    using System;
    using WalkInMatrix;

    using NUnit.Framework;

    [TestFixture]
    public class FindFreeCellTests : MatrixFake
    {
        [Test]
        public void PassingEmptyMatrix_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Matrix.FindFreeCell(null));
        }

        [Test]
        public void PassingFullMatrix_ThrowArgumentException()
        {
            int[,] matrix =
            {
                {
                    1,2
                },
                {
                    1,1
                }
            };

            Assert.Throws<ArgumentException>(() => Matrix.FindFreeCell(matrix));
        }
    }
}
