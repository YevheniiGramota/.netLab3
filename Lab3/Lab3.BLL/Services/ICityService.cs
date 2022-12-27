using Lab3.BLL.Models;

namespace Lab3.BLL.Services
{
    public interface ICityService
    {
        Task<CityDto> CreateCity(CityDto cityDto);
        Task DeleteCity(long id);
        Task<IEnumerable<CityDto>> GetCities();
        Task<CityDto> GetCity(long id);
        Task<CityDto> UpdateCity(long id, CityDto cityDto);
    }
}