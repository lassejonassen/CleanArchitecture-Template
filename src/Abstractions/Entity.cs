namespace Abstractions;

public abstract class Entity
{
    protected Entity(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("The entity identifier must not be empty.", nameof(id));
        }

        Id = id;
    }
    
    protected Entity() {}
    
    public Guid Id { get; set; }
}