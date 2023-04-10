using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Types.DateRange.Constraints;

public class MinDateConstraint : Constraint<DateRangeValue>
{
    public override string Name => "Min.DateRange";

    public override bool IsSatisfiedBy(DateRangeValue value)
    {
        return Value.StartDate > value.StartDate;
    }

    public override void Validate(DateRangeValue value)
    {
        if (!IsSatisfiedBy(value)) throw new DateRangeMinException(value);
    }
}