namespace ImanN.DynamicFields;

public class IntegerField : DynamicField<Guid, int>
{
    
    public IntegerField(
        DynamicFieldId<Guid> id, string name, 
        string title, bool isRequired, List<Constraint<int>> constraints
    ) : base(id, name, title, isRequired, constraints)
    {
    }
    
}