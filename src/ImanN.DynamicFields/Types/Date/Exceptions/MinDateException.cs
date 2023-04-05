namespace ImanN.DynamicFields.Exceptions;

public class MinDateException : DynamicFieldConstraintViolationException
{

    public MinDateException(DateOnly minValue)
        : base(message: $"[Min] You cannot assign a value less than '{minValue}'.")
    {
    }
}