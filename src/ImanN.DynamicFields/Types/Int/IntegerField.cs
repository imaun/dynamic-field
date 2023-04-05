namespace ImanN.DynamicFields;

/// <summary>
/// DynamicField which supports <see cref="Int32"/> type value.
/// </summary>
public class IntegerField : DynamicField<Guid, int>
{
    
    public IntegerField(
        DynamicFieldId<Guid> id, string name, 
        string title, bool isRequired, List<Constraint<int>> constraints
    ) : base(id, name, title, isRequired, constraints)
    {
    }
    
}