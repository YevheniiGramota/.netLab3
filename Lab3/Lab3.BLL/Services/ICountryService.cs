using Lab3.BLL.Models;

namespace Lab3.BLL.Services
{
    public interface ICountryService
    {
        Task<CountryDto> CreateCountry(CountryDto countryDto);
        Task DeleteCountry(long id);
        Task<IEnumerable<CountryDto>> GetCountries();
        Task<CountryDto> GetCountry(long id);
        Task<CountryDto> UpdateCountry(long id, CountryDto countryDto);
    }
}