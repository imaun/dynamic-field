using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

/// <summary>
/// A constraint on <see cref="DateField"/> which will make sure the value of 
/// the field is not greater than the value of the constraint.
/// </summary>
public class MaxDateConstraint : Constraint<DateOnly>
{
    public override string Name => "Date.Max";

    private DateOnly _maxDate;

    public MaxDateConstraint(DateOnly maxDate)
    {
        _maxDate = maxDate;
    }
    
    public override bool IsSatisfiedBy(DateOnly value)
    {
        return value < _maxDate;
    }

    public override void Validate(DateOnly value)
    {
        if (!IsSatisfiedBy(value)) throw new MaxDateException(value);
    }
}