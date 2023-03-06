namespace ImanN.DynamicFields.Exceptions;

public class DynamicFieldConstraintViolationException : Exception
{

    public DynamicFieldConstraintViolationException()
    {
    }

    public DynamicFieldConstraintViolationException(string message): base(message)
    {
    }
}