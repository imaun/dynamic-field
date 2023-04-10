using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

/// <summary>
/// A constraint on <see cref="DateField"/> which will make sure the value of
/// the field is not less than the value of this constraint.
/// </summary>
public class MinDateConstraint : Constraint<DateOnly>
{
    public override string Name => "Date.Min";


    public MinDateConstraint(DateOnly minValue)
    {
        Value = minValue;
    }

    public override bool IsSatisfiedBy(DateOnly value)
    {
        return value > Value;
    }

    public override void Validate(DateOnly value)
    {
        if (!IsSatisfiedBy(value)) throw new MinDateException(value);
    }
}