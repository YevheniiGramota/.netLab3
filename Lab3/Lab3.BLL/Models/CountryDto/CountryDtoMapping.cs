using AutoMapper;
using Lab3.DAL.Entities;

namespace Lab3.BLL.Models;

public class CountryDtoMapping : Profile
{
    public CountryDtoMapping()
    {
        CreateMap<Country, CountryDto>().ReverseMap();
    }
}