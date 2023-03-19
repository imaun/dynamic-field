namespace ImanN.DynamicFields;

public class DynamicFieldId<T> 
{

    public DynamicFieldId(T value)
    {
        Value = value;
    }
    
    public T Value { get; set; }


    public static DynamicFieldId<T> Create(T value)
    {
        return new DynamicFieldId<T>(value);
    }

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