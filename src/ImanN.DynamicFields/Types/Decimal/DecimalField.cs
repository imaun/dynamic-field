namespace ImanN.DynamicFields;

/// <summary>
/// DynamicField which supports <see cref="decimal"/> type value.
/// </summary>
public class DecimalField : DynamicField<Guid, decimal>
{

    public DecimalField(
        DynamicFieldId<Guid> id, string name, string title,
        bool isRequired, int decimalPlace, List<Constraint<decimal>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
        DecimalPlace = decimalPlace;
    }
    
    public int DecimalPlace { get; }


    public override void SetValue(decimal value)
    {
        base.SetValue(value);
        Value = IgnoreAfterDecimalPlace(Value, DecimalPlace);
    }

    private decimal IgnoreAfterDecimalPlace(decimal value, int decimalPlace)
    {
         return Math.Round(value, decimalPlace);
    }
}