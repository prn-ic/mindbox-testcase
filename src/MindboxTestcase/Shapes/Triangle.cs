using MindboxTestcase.Exceptions;
using MindboxTestcase.Specifications;

namespace MindboxTestcase.Shapes;

public class Triangle : Shape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        GuardException.ThrowIfDecimalValueLessThanZero(a);
        GuardException.ThrowIfDecimalValueLessThanZero(b);
        GuardException.ThrowIfDecimalValueLessThanZero(c);

        A = a;
        B = b;
        C = c;
    }

    public override double GetSquare()
    {
        var existTriangleSpec = new ExistTriangleSpecification();
        if (!existTriangleSpec.IsSatisfiedBy(this))
            throw new NotExistanseTriangleParametersException(A, B, C);

        var p = (A + B + C) / 2;
        var square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        return square;
    }

    public bool IsRight()
    {
        var triangleIsRightSpec = new TriangleIsRightSpecification();
        var existTriangleSpec = new ExistTriangleSpecification();

        return triangleIsRightSpec.And(existTriangleSpec).IsSatisfiedBy(this);
    }
}
