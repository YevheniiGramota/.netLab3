namespace Lab3.DAL.Entities;

public class Country : IdentifiedEntity
{
    public string Name { get; set; } = null!;
    public ICollection<City> Cities { get; } = null!;
}

