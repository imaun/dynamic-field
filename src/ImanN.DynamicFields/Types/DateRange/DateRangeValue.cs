using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Types.DateRange;

public class DateRangeValue
{
    public DateTime StartDate { get; }

    public DateTime EndDate { get; }

    public DateRangeValue(DateTime startDate, DateTime endDate)
    {
        GuardAgainstStartDateBiggerThanEndDate(startDate, endDate);

        StartDate = startDate;
        EndDate = endDate;
    }

    private static void GuardAgainstStartDateBiggerThanEndDate(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
            throw new DateRangeStartDateGreaterThanEndDateException();
    }

    public static DateRangeValue Create(DateTime startDate, DateTime endDate)
        => new DateRangeValue(startDate, endDate);
}