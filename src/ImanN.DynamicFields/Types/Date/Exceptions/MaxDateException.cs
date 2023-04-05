namespace ImanN.DynamicFields.Exceptions;

public class MaxDateException : DynamicFieldConstraintViolationException
{

    public MaxDateException(DateOnly value)
        : base(message: $"[Max] You cannot assign a value greater than '{value.ToShortDateString()}'")
    {
    }
}