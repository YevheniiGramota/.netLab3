namespace Lab3.DAL.Entities;

public class Message : IdentifiedEntity
{
    public DateTime CreatedAt { get; set; }

    public long EventId { get; set; }
    public Event Event { get; set; } = null!;

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
}
