namespace ImanN.DynamicFields.Contracts;

public interface ISpecification<in TValue>
{
    
    bool IsSatisfiedBy(TValue value);
}