using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

/// <summary>
/// Maximum constraint for <see cref="IntegerField"/>
/// This make sures the value of field is always less than the Max value. 
/// </summary>
public class MaxIntegerConstraint : Constraint<int>
{
   
    
    public MaxIntegerConstraint(int max)
    {
        Value = max;
    }
    
    public override string Name => "Int.Max";
    
    public override bool IsSatisfiedBy(int value)
    {
        return value < Value;
    }

    public override void Validate(int value)
    {
        if (!IsSatisfiedBy(value)) throw new MaxIntegerException(Value);
    }
}