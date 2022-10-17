using MindboxTest;

namespace MindboxTest.Tests
{
    public class CircleTests
    {

        [Test]
        public void ValidateTest()
        {
            // Arrange
            Circle circle = new(-1);

            // Assert
            Assert.Throws<ArgumentException>(() => circle.Validate());
        }

        [Test]
        public void GetAreaTests()
        {
            // Arrange
            Circle circle = new(10);

            // Act
            double actual = circle.GetArea();
            actual = Math.Round(actual, 4);
            
            // Assert
            Assert.AreEqual(314.1593, actual);

        }
    }
}