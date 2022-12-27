using AutoMapper;
using Lab3.BLL.Models;
using Lab3.DAL.Entities;
using Lab3.DAL.Repositories;

namespace Lab3.BLL.Services;

public class CountryService : ICountryService
{
    private readonly CountryRepository _repository;
    private readonly IMapper _mapper;

    public CountryService(CountryRepository countryRepository, IMapper mapper)
    {
        _repository = countryRepository;
        _mapper = mapper;
    }

    public async Task<CountryDto> GetCountry(long id)
    {
        Country? country = await _repository.GetEntityByIdAsync(id);

        if (country is null)
        {
            throw new ArgumentException("", nameof(id));
        }

        return _mapper.Map<CountryDto>(country);
    }

    public async Task<IEnumerable<CountryDto>> GetCountries()
    {
        List<Country> countries = await _repository.GetEntitiesAsync();

        return _mapper.Map<IEnumerable<CountryDto>>(countries);
    }

    public async Task<CountryDto> CreateCountry(CountryDto countryDto)
    {
        Country country = _mapper.Map<Country>(countryDto);

        await _repository.CreateAsync(country);
        await _repository.SaveAsync();

        return _mapper.Map<CountryDto>(country);
    }

    public async Task DeleteCountry(long id)
    {
        Country? country = await _repository.GetEntityByIdAsync(id);

        if (country is null)
        {
            throw new ArgumentException("", nameof(id));
        }

        _repository.Delete(country);
        await _repository.SaveAsync();
    }

    public async Task<CountryDto> UpdateCountry(long id, CountryDto countryDto)
    {
        Country? country = await _repository.GetEntityByIdAsync(id);

        if (country is null || countryDto.Id != id)
        {
            throw new ArgumentException("", nameof(id));
        }

        country = _mapper.Map(countryDto, country);

        _repository.Update(country);
        await _repository.SaveAsync();

        return _mapper.Map<CountryDto>(country);
    }
}
