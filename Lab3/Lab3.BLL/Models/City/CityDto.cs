using Lab3.DAL.Entities;

namespace Lab3.BLL.Models;

public class CityDto : IdentifiedDto
{
    public string Name { get; set; } = null!;
    public long CountryId { get; set; }
}
