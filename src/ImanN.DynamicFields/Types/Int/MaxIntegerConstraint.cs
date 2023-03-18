namespace ImanN.DynamicFields;


public class MaxIntegerConstraint : Constraint<int>
{
    private int _max;
    
    public MaxIntegerConstraint(int max)
    {
        _max = max;
    }
    
    public override string Key => "Int.Max";
    
    public override bool IsSatisfiedBy(int value)
    {
        return value < _max;
    }
}