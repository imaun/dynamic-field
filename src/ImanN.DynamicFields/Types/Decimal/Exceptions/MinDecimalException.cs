namespace ImanN.DynamicFields.Exceptions;

public class MinDecimalException : DynamicFieldConstraintViolationException
{

    public MinDecimalException(decimal min)
        : base(message: $"[Min] You cannot assign a value less than '{min}' .")
    {
    }
}