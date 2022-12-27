namespace Lab3.DAL.Entities;

public class City : IdentifiedEntity
{
    public string Name { get; set; } = null!;

    public long CountryId { get; set; }
    public Country Country { get; set; } = null!;
}

