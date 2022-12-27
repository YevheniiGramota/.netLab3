namespace Lab3.DAL.Entities;

public abstract class IdentifiedEntity<T> : EntityBase
{
    public T Id { get; set; } = default!;
}

public abstract class IdentifiedEntity : IdentifiedEntity<long>
{

}