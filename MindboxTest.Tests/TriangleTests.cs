using MindboxTest;

namespace MindboxTest.Tests
{
    public class TriangleTests
    {

        [Test]
        public void ValidateTest()
        {
            // Arrange
            Triangle triangle = new(-1, -5, 9);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.Validate());
        }

        [TestCase(9,10,17,36)]
        public void GetAreaTest(double sideA, double sideB, double sideC, double expected)
        {
            // Arrange
            Triangle triangle = new(sideA, sideB, sideC);

            // Act
            double actual = triangle.GetArea();
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 10, 17, false)]
        [TestCase(3, 4, 5, true)]
        public void IsRectangularTest(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange
            Triangle triangle = new(sideA, sideB, sideC);

            // Act
            bool actual = triangle.IsRectangular();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}