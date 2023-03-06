using ImanN.DynamicFields.Contracts;

namespace ImanN.DynamicFields;

public abstract class Constraint : IConstraint
{
    public abstract string Key { get; }
    
    public string Value { get; protected set; }
    
    public abstract bool IsSatisfiedBy(string entity);
}