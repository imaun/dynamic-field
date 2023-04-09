namespace ImanN.DynamicFields;

/// <summary>
/// It's a List of Values with same type.
/// </summary>
/// <typeparam name="TValue"></typeparam>
public class ArrayField<TValue> : DynamicField<Guid, ArrayFieldValue<TValue>>
{
    
    public ArrayField(
        DynamicFieldId<Guid> id, string name, 
        string title, bool isRequired, 
        List<Constraint<ArrayFieldValue<TValue>>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
        SetValue(new ArrayFieldValue<TValue>());
    }
    
}