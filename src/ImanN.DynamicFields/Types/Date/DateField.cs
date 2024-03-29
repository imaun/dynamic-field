namespace ImanN.DynamicFields;

/// <summary>
/// DynamicField which supports <see cref="DateOnly"/> type value.
/// </summary>
public class DateField : DynamicField<Guid, DateOnly>
{

    public DateField(
        DynamicFieldId<Guid> id, string name, string title,
        bool isRequired, List<Constraint<DateOnly>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
    }
    
    
    public int Year => Value.Year;

    public int Month => Value.Month;

    public int Day => Value.Day;

    public void SetYear(int year)
    {
        SetValue(new DateOnly(year, Month, Day));
    }

    public void SetMonth(int month)
    {
         SetValue(new DateOnly(Year, month, Day));
    }

    public void SetDay(int day)
    {
        SetValue(new DateOnly(Year, Month, day));
    }

    public void Set(int year, int month, int day)
    {
        SetValue(new DateOnly(year, month, day));
    }
}