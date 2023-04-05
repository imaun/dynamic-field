using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

/// <summary>
/// A constraint on <see cref="DateField"/> which will make sure the value of
/// the field is not less than the value of this constraint.
/// </summary>
public class MinDateConstraint : Constraint<DateOnly>
{
    public override string Name => "Date.Min";

    private readonly DateOnly _minValue;

    public MinDateConstraint(DateOnly minValue)
    {
        _minValue = minValue;
    }

    public override bool IsSatisfiedBy(DateOnly value)
    {
        return value > _minValue;
    }

    public override void Validate(DateOnly value)
    {
        if (!IsSatisfiedBy(value)) throw new MinDateException(value);
    }
}