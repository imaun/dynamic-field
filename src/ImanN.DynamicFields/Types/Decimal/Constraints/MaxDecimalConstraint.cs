using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields.Constraints;

/// <summary>
/// Maximum constraint for <see cref="DecimalField"/> 
/// This makes sures the value of field is always less than the Max value.
/// </summary>
public class MaxDecimalConstraint : Constraint<decimal>
{
    private decimal _max;

    public MaxDecimalConstraint(decimal max)
    {
        _max = max;
    }

    public override string Name => "Decimal.Max";
    
    public override bool IsSatisfiedBy(decimal value)
    {
        return value < _max;
    }

    public override void Validate(decimal value)
    {
        if (!IsSatisfiedBy(value)) throw new MaxDecimalException(_max);
    }
}