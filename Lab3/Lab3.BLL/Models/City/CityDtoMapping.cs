using AutoMapper;
using Lab3.DAL.Entities;

namespace Lab3.BLL.Models;

public class CityDtoMapping : Profile
{
    public CityDtoMapping()
    {
        CreateMap<City, CityDto>().ReverseMap();
    }
}