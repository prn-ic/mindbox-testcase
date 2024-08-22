namespace MindboxTestcase.Exceptions;

public class GuardException
{
    public static void ThrowIfDecimalValueLessThanZero(double value)
    {
        if (value < 0)
            throw new InvalidSizeException(value);
    }
}