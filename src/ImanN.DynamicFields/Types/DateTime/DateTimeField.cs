namespace ImanN.DynamicFields;

/// <summary>
/// DynamicField which supports <see cref="DateTime"/> type value.
/// </summary>
public class DateTimeField : DynamicField<Guid, DateTime>
{

    public DateTimeField(
        DynamicFieldId<Guid> id, string name, string title,
        bool isRequired, List<Constraint<DateTime>> constraints
        ): base(id, name, title, isRequired, constraints)
    {
    }
}