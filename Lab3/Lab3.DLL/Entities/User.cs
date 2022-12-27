namespace Lab3.DAL.Entities;

public class User : IdentifiedEntity<Guid>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Telephone { get; set; } = null!;


    public long CityId { get; set; }
    public City City { get; set; } = null!;

    public long ImageId { get; set; }
    public Image Image { get; set; } = null!;

    public ICollection<Role> Roles { get; } = null!;
    public ICollection<Event> Events { get; } = null!;
    public ICollection<Message> Messages { get; } = null!;
}
