using Lab3.DAL.Entities;

namespace Lab3.BLL.Models;

public class CountryDto : IdentifiedDto
{
    public string Name { get; set; } = null!;
}
