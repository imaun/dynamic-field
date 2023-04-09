namespace ImanN.DynamicFields.Persistence.DataModels;

public class DynamicFieldDataModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Title { get; set; }
    
    public bool IsRequired { get; set; }
    
    public bool IsActive { get; set; }
    
    public string Value { get; set; }
    
    
}