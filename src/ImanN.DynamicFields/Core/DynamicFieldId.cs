namespace ImanN.DynamicFields;

public abstract class DynamicFieldId<T> 
{

    public DynamicFieldId(T value)
    {
        Value = value;
    }
    
    public T Value { get; set; }
    

    public override bool Equals(object obj)
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }

        var other = (DynamicFieldId<T>)obj;
        return other.Value.Equals(this.Value);
    }

}