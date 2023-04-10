using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Constraints;

public class MinDateTimeConstraint : Constraint<DateTime>
{
    public override string Name => "Min.DateTime";

    public MinDateTimeConstraint(DateTime value)
    {
        Value = value;
    }

    public override bool IsSatisfiedBy(DateTime value)
    {
        return DateTime.Compare(Value, value) < 0;
    }

    public override void Validate(DateTime value)
    {
        if (!IsSatisfiedBy(value)) throw new MinDateTimeException(value);
    }
}