using MindboxTestcase.Shapes;
using MindboxTestcase.Specifications;

namespace MindboxTestCase.UnitTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5)]
    public void InitializeTriangle_WithValidParameters_ShouldBeOk(double a, double b, double c)
    {
        // Act
        Triangle triangle = new Triangle(a, b, c);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    public void GetSquare_WithValidParameters_ShouldBeOk(double a, double b, double c, double s)
    {
        // Arrange
        Triangle triangle = new Triangle(a, b, c);

        // Act
        double actual = triangle.GetSquare();

        // Assert
        Assert.Equal(s, actual);
    }

    [Theory]
    [InlineData(5, 3, 4)]
    public void IsRight_WithRightTriangle_ReturnsTrue(double a, double b, double c)
    {
        // Arrange
        Triangle triangle = new Triangle(a, b, c);
        bool expected = true;

        // Act
        bool actual = triangle.IsRight();

        // Assert
        Assert.Equal(expected, actual);
    }
}
