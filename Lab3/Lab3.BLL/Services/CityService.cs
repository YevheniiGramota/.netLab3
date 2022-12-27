using AutoMapper;
using Lab3.BLL.Models;
using Lab3.DAL.Entities;
using Lab3.DAL.Repositories;

namespace Lab3.BLL.Services;

public class CityService : ICityService
{
    private readonly CityRepository _repository;
    private readonly IMapper _mapper;

    public CityService(CityRepository cityRepository, IMapper mapper)
    {
        _repository = cityRepository;
        _mapper = mapper;
    }

    public async Task<CityDto> GetCity(long id)
    {
        City? city = await _repository.GetEntityByIdAsync(id);

        if (city is null)
        {
            throw new ArgumentException("", nameof(id));
        }

        return _mapper.Map<CityDto>(city);
    }

    public async Task<IEnumerable<CityDto>> GetCities()
    {
        List<City> cities = await _repository.GetEntitiesAsync();

        return _mapper.Map<IEnumerable<CityDto>>(cities);
    }

    public async Task<CityDto> CreateCity(CityDto cityDto)
    {
        City city = _mapper.Map<City>(cityDto);

        await _repository.CreateAsync(city);
        await _repository.SaveAsync();

        return _mapper.Map<CityDto>(city);
    }

    public async Task DeleteCity(long id)
    {
        City? city = await _repository.GetEntityByIdAsync(id);

        if (city is null)
        {
            throw new ArgumentException("", nameof(id));
        }

        _repository.Delete(city);
        await _repository.SaveAsync();
    }

    public async Task<CityDto> UpdateCity(long id, CityDto cityDto)
    {
        City? city = await _repository.GetEntityByIdAsync(id);

        if (city is null || cityDto.Id != id)
        {
            throw new ArgumentException("", nameof(id));
        }

        city = _mapper.Map(cityDto, city);

        _repository.Update(city);
        await _repository.SaveAsync();

        return _mapper.Map<CityDto>(city);
    }
}
