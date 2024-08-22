using MindboxTestcase.Exceptions;

namespace MindboxTestcase.Shapes;

public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        GuardException.ThrowIfDecimalValueLessThanZero(radius);

        Radius = radius;
    }
    public override double GetSquare()
    {
        return Math.PI * (Radius * Radius);
    }
}