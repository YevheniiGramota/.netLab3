namespace Lab3.DAL.Entities;

public class Category : IdentifiedEntity
{
    public string Name { get; set; } = null!;
    public ICollection<Event> Events { get; } = null!;
}
