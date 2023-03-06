using ImanN.DynamicFields.Contracts;
using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;


public abstract class DynamicField<TId, TValue> : IDynamicField<TValue>
{
    private List<Constraint<TValue>> _constraints;

    public DynamicField(
        DynamicFieldId<TId> id, string name, string title, 
        bool isRequired, List<Constraint<TValue>> constraints)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
        Name = name;
        Title = title;
        IsRequired = isRequired;
        _constraints = constraints ?? new List<Constraint<TValue>>();
    }
    
    public IReadOnlyCollection<Constraint<TValue>> Constraints => _constraints.AsReadOnly();
    
    public DynamicFieldId<TId> Id { get; set; }
    
    public string Title { get; protected set; }
    
    public string Name { get; protected set; }

    public bool IsActive { get; protected set; }
    
    public TValue Value { get; protected set; }
    
    public bool IsRequired { get; protected set; }

    public void SetValue(TValue value)
    {
        GuardAgainstViolatedConstraints(value);
        Value = value;
    }

    public void Disable() => IsActive = false;

    public void Enable() => IsActive = true;


    private void GuardAgainstViolatedConstraints(TValue value)
    {
        var violations = _constraints.Where(_ => !_.IsSatisfiedBy(value)).ToList();
        if (violations.Any())
            throw new DynamicFieldConstraintViolationException();
    }
}