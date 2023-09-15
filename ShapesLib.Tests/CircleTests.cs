using FluentAssertions;
using ShapesLib;
namespace ShapesLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_PassRadius_ReturnsArea()
        {
            // Arrange
            int r = 5;
            Circle circle = new Circle(r);

            // Act

            // Assert
            circle.Area.Should().BeApproximately(78.54, 0.01);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Circle_PassZeroOrNegative_ThrowsException(int radius)
        {
            // Arrange
            Action createCircle = () => new Circle(radius);

            // Act

            // Assert
            createCircle.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Circle_ToString_ReturnsString()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            Triangle triangleRight = new Triangle(a, b, c);
            a = 4;
            Triangle triangleNotRight = new Triangle(a, b, c);

            // Act
            string resultRight = triangleRight.ToString();
            string resultNotRight = triangleNotRight.ToString();

            // Assert
            resultRight.Should().Be("A right-angled triangle with sides of length 3, 4, 5 and area of 6");
            resultNotRight.Should().Be("A triangle with sides of length 4, 4, 5 and area of 7,806");

        }
    }
}