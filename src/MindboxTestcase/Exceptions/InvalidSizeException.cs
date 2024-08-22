namespace MindboxTestcase.Exceptions;

public class InvalidSizeException : DomainException
{
    private double _size;
    private double _min = 0;
    public override string Message =>
        string.Format("Недопустимый размер: {0}; Минимально разрешено: {1}", _size, _min);

    public InvalidSizeException(double size)
    {
        _size = size;
    }

    public InvalidSizeException(double size, double min)
    {
        _size = size;
        _min = min;
    }
}
