using ImanN.DynamicFields.Types.DateRange;

namespace ImanN.DynamicFields.Exceptions;

public class DateRangeMinException : DynamicFieldConstraintViolationException
{
    public DateRangeMinException(DateRangeValue value) : base(
        message: $"[Min] You cannot assign a value greater than '{value.StartDate.ToShortDateString()}'")
    {
    }
}