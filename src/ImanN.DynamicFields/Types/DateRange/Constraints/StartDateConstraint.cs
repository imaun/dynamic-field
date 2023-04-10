using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Types.DateRange.Constraints;

public class StartDateConstraint : Constraint<DateOnly>
{
    public StartDateConstraint(DateOnly startDate)
    {
        Value = startDate;
    }

    public override string Name => "StartDate.DateRange";

    public override bool IsSatisfiedBy(DateOnly endDate)
    {
        return Value < endDate;
    }

    public override void Validate(DateOnly value)
    {
        if (!IsSatisfiedBy(value)) throw new DateRangeStartDateGreaterThanEndDateException();
    }
}