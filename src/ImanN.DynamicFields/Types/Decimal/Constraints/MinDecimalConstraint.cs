using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Constraints;

/// <summary>
/// Minimum Constraint for <see cref="DecimalField"/>
/// This make sures the value of field is always bigger than the Min value.
/// </summary>
public class MinDecimalConstraint : Constraint<decimal>
{
    private decimal _min;

    public MinDecimalConstraint(decimal min)
    {
        _min = min;
    }

    public override string Name => "Decimal.Min";
    
    public override bool IsSatisfiedBy(decimal value)
    {
        return value > _min;
    }

    public override void Validate(decimal value)
    {
        if (!IsSatisfiedBy(value)) throw new MinDecimalException(_min);
    }
}