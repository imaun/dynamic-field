namespace ImanN.DynamicFields.Contracts;

public interface IDynamicField
{
    void SetValue(string value);
    
    string Value { get; }
}