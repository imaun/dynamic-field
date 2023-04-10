using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Types.DateRange.Constraints;

public class MinDateRangeConstraint : Constraint<DateRangeValue>
{
    public override string Name => "Min.DateRange";

    public MinDateRangeConstraint(DateRangeValue value)
    {
        Value = value;
    }

    public override bool IsSatisfiedBy(DateRangeValue value)
    {
        return Value.StartDate < value.StartDate;
    }

    public override void Validate(DateRangeValue value)
    {
        if (!IsSatisfiedBy(value)) throw new DateRangeMinException(value);
    }
}