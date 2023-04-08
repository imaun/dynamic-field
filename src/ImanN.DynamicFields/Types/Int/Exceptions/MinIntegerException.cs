using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

public class MinIntegerException : DynamicFieldConstraintViolationException
{
    
    public MinIntegerException(int min)
        : base(message: $"[Min] You cannot assign a value less than '{min}' .")
    {
    }
}