using ImanN.DynamicFields.Types.DateRange;

namespace ImanN.DynamicFields.Exceptions;

public class DateRangeMaxException : DynamicFieldConstraintViolationException
{
    public DateRangeMaxException(DateRangeValue value) : base(
        message: $"[Max] You cannot assign a value greater than '{value.EndDate.ToShortDateString()}'")
    {
    }
}