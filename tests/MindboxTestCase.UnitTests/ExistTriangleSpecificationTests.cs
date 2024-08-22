using MindboxTestcase.Shapes;
using MindboxTestcase.Specifications;

namespace MindboxTestCase.UnitTests;

public class ExistTriangleSpecificationTests
{
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(13, 12, 5)]
    [InlineData(17, 8, 15)]
    [InlineData(6, 8, 10)]
    public void ExistTriangleSpecification_WithValidParameters_ReturnsTrue(double a, double b, double c)
    {
        // Arrange
        Triangle triangle = new Triangle(a, b, c);
        ExistTriangleSpecification specification = new ExistTriangleSpecification();
        bool expected = true;

        // Act
        bool actual  = specification.IsSatisfiedBy(triangle);

        // Assert
        Assert.Equal(expected, actual);
    }    
}