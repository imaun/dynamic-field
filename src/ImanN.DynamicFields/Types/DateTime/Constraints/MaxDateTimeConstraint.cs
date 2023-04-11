using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Constraints;

public class MaxDateTimeConstraint : Constraint<DateTime>
{
    public override string Name => "Max.DateTime";

    public MaxDateTimeConstraint(DateTime value)
    {
        Value = value;
    }

    public override bool IsSatisfiedBy(DateTime value)
    {
        return DateTime.Compare(Value, value) > 0;
    }

    public override void Validate(DateTime value)
    {
        if (!IsSatisfiedBy(value)) throw new MaxDateTimeException(value);
    }
}