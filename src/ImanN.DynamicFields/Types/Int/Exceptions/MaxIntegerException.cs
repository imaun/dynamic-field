namespace ImanN.DynamicFields.Exceptions;

public class MaxIntegerException : DynamicFieldConstraintViolationException
{

    public MaxIntegerException(int max)
        : base(message: $"[Max] You cannot assign a value bigger than '{max}' .")
    {
    }
}