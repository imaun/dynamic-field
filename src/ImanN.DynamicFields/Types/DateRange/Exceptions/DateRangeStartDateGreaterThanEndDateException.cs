namespace ImanN.DynamicFields.Exceptions;

public class DateRangeStartDateGreaterThanEndDateException : Exception
{

    public DateRangeStartDateGreaterThanEndDateException()
        : base(message: "The StartDate cannot be greater than EndDate.")
    {
    }
}