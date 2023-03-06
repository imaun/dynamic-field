namespace ImanN.DynamicFields.Contracts;

public interface ISpecification<in T>
{
    
    bool IsSatisfiedBy(T entity);
}