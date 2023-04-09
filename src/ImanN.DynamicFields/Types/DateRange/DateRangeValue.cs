using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Types.DateRange;

public class DateRangeValue
{
    public DateRangeValue(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
            throw new DateRangeStartDateGreaterThanEndDateException();
        
        StartDate = startDate;
        EndDate = endDate;
    }
    
    public DateTime StartDate { get; }
    
    public DateTime EndDate { get; }

    public static DateRangeValue Create(DateTime startDate, DateTime endDate)
        => new DateRangeValue(startDate, endDate);
}