namespace ImanN.DynamicFields.Exceptions;

public class MaxDateTimeException : DynamicFieldConstraintViolationException
{
    public MaxDateTimeException(DateTime max) : base(
        message: $"[Max] You cannot assign a value greater than '{max.ToShortDateString()}'")
    {
    }
}