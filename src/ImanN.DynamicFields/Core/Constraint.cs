using ImanN.DynamicFields.Contracts;

namespace ImanN.DynamicFields;

public abstract class Constraint<TValue> : IConstraint<TValue>
{
    public abstract string Name { get; }
    
    public TValue Value { get; protected set; }
    
    public abstract bool IsSatisfiedBy(TValue value);

    public abstract void Validate(TValue value);
}