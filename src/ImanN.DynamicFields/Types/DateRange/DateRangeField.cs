namespace ImanN.DynamicFields.Types.DateRange;

public class DateRangeField : DynamicField<Guid, DateRangeValue>
{

    public DateRangeField(
        DynamicFieldId<Guid> id, string name, string title,
        bool isRequired, List<Constraint<DateRangeValue>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
    }
    
}


