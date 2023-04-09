namespace ImanN.DynamicFields.Exceptions;

public class MaxDecimalException : DynamicFieldConstraintViolationException
{

    public MaxDecimalException(decimal max)
        : base(message: $"[Max] You cannot assign a value bigger than '{max}' .")
    {
    }
}