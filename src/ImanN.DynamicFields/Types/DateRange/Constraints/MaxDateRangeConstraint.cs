using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Types.DateRange.Constraints;

public class MaxDateRangeConstraint : Constraint<DateRangeValue>
{
    public override string Name => "Max.DateRange";

    public MaxDateRangeConstraint(DateRangeValue value)
    {
        Value = value;
    }

    public override bool IsSatisfiedBy(DateRangeValue value)
    {
        return Value.EndDate > value.EndDate;
    }

    public override void Validate(DateRangeValue value)
    {
        if (!IsSatisfiedBy(value)) throw new DateRangeMaxException(value);
    }
}