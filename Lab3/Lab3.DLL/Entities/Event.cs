namespace Lab3.DAL.Entities;

public class Event : IdentifiedEntity
{
    public string Name { get; set; } = null!;

    public long GalleryId { get; set; }
    public Gallery Gallery { get; set; } = null!;

    public ICollection<Category> Categories { get; } = null!;
    public ICollection<Message> Messages { get; } = null!;
    public ICollection<User> Users { get; } = null!;
}
