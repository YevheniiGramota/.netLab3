namespace Lab3.DAL.Entities;

public class Role : IdentifiedEntity<Guid>
{
    public string Name { get; set; } = null!;
    public ICollection<User> Users { get; } = null!;
}
