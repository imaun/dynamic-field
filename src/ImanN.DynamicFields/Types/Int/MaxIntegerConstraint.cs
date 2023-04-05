using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;


public class MaxIntegerConstraint : Constraint<int>
{
    private int _max;
    
    public MaxIntegerConstraint(int max)
    {
        _max = max;
    }
    
    public override string Name => "Int.Max";
    
    public override bool IsSatisfiedBy(int value)
    {
        return value < _max;
    }

    public override void Validate(int value)
    {
        if (!IsSatisfiedBy(value)) throw new MaxIntegerException(_max);
    }
}