namespace ImanN.DynamicFields.Contracts;

public interface IDynamicField<TValue>
{
    void SetValue(TValue value);
    
    TValue Value { get; }
}