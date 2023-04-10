using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

/// <summary>
/// A constraint on <see cref="DateField"/> which will make sure the value of 
/// the field is not greater than the value of this constraint.
/// </summary>
public class MaxDateConstraint : Constraint<DateOnly>
{
    public override string Name => "Date.Max";


    public MaxDateConstraint(DateOnly maxDate)
    {
        Value = maxDate;
    }

    public override bool IsSatisfiedBy(DateOnly value)
    {
        return value < Value;
    }

    public override void Validate(DateOnly value)
    {
        if (!IsSatisfiedBy(value)) throw new MaxDateException(value);
    }
}