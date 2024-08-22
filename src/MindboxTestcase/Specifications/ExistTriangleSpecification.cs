using System.Linq.Expressions;
using MindboxTestcase.Shapes;

namespace MindboxTestcase.Specifications;

public class ExistTriangleSpecification : Specification<Triangle>
{
    public override Expression<Func<Triangle, bool>> ToExpression()
    {
        return t =>
            (t.A + t.B) > t.C
            || (t.A + t.C) > t.B
            || (t.B + t.C) > t.A;
    }
}
