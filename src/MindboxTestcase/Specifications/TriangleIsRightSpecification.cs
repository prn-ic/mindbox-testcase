using System.Linq.Expressions;
using MindboxTestcase.Shapes;

namespace MindboxTestcase.Specifications;

public class TriangleIsRightSpecification : Specification<Triangle>
{
    public override Expression<Func<Triangle, bool>> ToExpression()
    {
        return t =>
            IsRightTriangleBySides(t.A, t.B, t.C)
            || IsRightTriangleBySides(t.B, t.A, t.C)
            || IsRightTriangleBySides(t.C, t.B, t.A);
    }

    private bool IsRightTriangleBySides(double pseudoMax, double b, double c)
    {
        double left = pseudoMax * pseudoMax;
        double right = (b * b) + (c * c);

        return left == right;
    }
}
