namespace ImanN.DynamicFields;

public class BooleanField : DynamicField<Guid, bool>
{
    public BooleanField(
        DynamicFieldId<Guid> id, 
        string name, 
        string title, 
        bool isRequired, 
        List<Constraint<bool>> constraints) : base(id, name, title, isRequired, constraints)
    {
    }
    
    public string TrueCaption { get; set; }
    public string FalseCaption { get; set; }
    
    public string TrueCaptionSlug { get; set; }
    public string FalseCaptionSlug { get; set; }
}

public class BoolSample
{
    
    private BooleanField Field { get; set; }


    public BoolSample()
    {
        Field = new BooleanField(
            new DynamicFieldId<Guid>(Guid.NewGuid()), "bool", "bool", false, null
            );
    }

    public void Run()
    {
        Field.SetValue(true);
        
    }
}