using ImanN.DynamicFields.Contracts;

namespace ImanN.DynamicFields;


public abstract class DynamicField<TId, TValue> : IDynamicField<TValue>
{
    private List<Constraint<TValue>> _constraints;
    protected TValue _value;

    public DynamicField(
        DynamicFieldId<TId> id, string name, string title, 
        bool isRequired, List<Constraint<TValue>> constraints)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
        Name = name;
        Title = title;
        Required = isRequired;
        _constraints = constraints ?? new();
    }

    protected DynamicField(DynamicFieldId<TId> id)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
        _constraints = new();
    }

    /// <summary>
    /// This is a parameterless ctor. You have to initialize the <see cref="Id"/> properly.
    /// </summary>
    protected DynamicField()
    {
        _constraints = new();
    }

    public IReadOnlyCollection<Constraint<TValue>> Constraints => _constraints.AsReadOnly();
    
    public DynamicFieldId<TId> Id { get; set; }
    
    public string Title { get; protected set; }
    
    public string Name { get; protected set; }

    public bool IsActive { get; protected set; }

    public TValue Value => _value;
    
    public bool Required { get; protected set; }

    public virtual void SetValue(TValue value)
    {
        GuardAgainstViolatedConstraints(value);
        _value = value;
    }

    public void Disable() => IsActive = false;

    public void Enable() => IsActive = true;


    private void GuardAgainstViolatedConstraints(TValue value)
    {
        if(!_constraints.Any()) return;
        
        foreach(var c in _constraints)
            c.Validate(value);
    }

    public void AddConstraint(Constraint<TValue> constraint)
    {
        _constraints.Add(constraint);
    }

    public void RemoveConstraint(Constraint<TValue> constraint)
    {
        _constraints.Remove(constraint);
    }
}