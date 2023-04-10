namespace ImanN.DynamicFields.Exceptions;

public class MinDateTimeException : DynamicFieldConstraintViolationException
{
    public MinDateTimeException(DateTime min) : base(
        $"[Min] You cannot assign a value greater than '{min.ToShortDateString()}'")
    {
    }
}