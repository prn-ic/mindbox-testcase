namespace MindboxTestcase.Exceptions;

public class NotExistanseTriangleParametersException : DomainException
{
    private double _a;
    private double _b;
    private double _c;
    public override string Message =>
        string.Format(
            "Треугольник не может существовать с такими параметрами, где A = {0}, B = {1}, C - {2}",
            _a,
            _b,
            _c
        );

    public NotExistanseTriangleParametersException(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }
}
