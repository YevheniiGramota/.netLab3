namespace Lab3.DAL.Entities;

public class Gallery : IdentifiedEntity
{
    public string Name { get; set; } = null!;
    public ICollection<Image> Images { get; } = null!;
}
