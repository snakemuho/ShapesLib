using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_PassCorrectSides_ReturnsArea()
        {
            // Arrange
            int a = 7, b = 10, c = 5;
            Triangle triangle = new Triangle(a, b, c);

            // Act

            // Assert
            triangle.Area.Should().BeApproximately(16.248, 0.001);
        }

        [Theory]
        [InlineData(1, 0, 2)]
        [InlineData(-5, 5, 5)]
        [InlineData(5, 8, 2)]
        public void Triangle_PassIncorrectSides_ThrowsException(int a, int b, int c)
        {
            // Arrange
            Action createdTriangle = () => new Triangle(a, b, c);

            // Act

            // Assert
            createdTriangle.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(4, 3, 5)]
        [InlineData(7, 25, 24)]
        public void Triangle_CheckIfRight_ReturnsTrue(int a, int b, int c)
        {
            // Arrange
            bool result = Triangle.CheckIfRight(a, b, c);

            // Act

            // Assert
            result.Should().Be(true);
        }

        [Theory]
        [InlineData(4, 4, 4)]
        [InlineData(7, 10, 5)]
        public void Triangle_CheckIfRight_ReturnsFalse(int a, int b, int c)
        {
            // Arrange
            bool result;

            // Act
            result = Triangle.CheckIfRight(a, b, c);

            // Assert
            result.Should().Be(false);
        }

        [Fact]
        public void Triangle_ToString_ReturnsString()
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
