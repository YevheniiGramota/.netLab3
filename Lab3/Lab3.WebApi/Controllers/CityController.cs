using Lab3.BLL.Models;
using Lab3.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.WebApi.Controllers;

public class CityController : ApiControllerBase
{
    private readonly ICityService _cityService;

    public CityController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCities()
    {
        IEnumerable<CityDto> cities = await _cityService.GetCities();
        return Ok(cities);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCity(long id)
    {
        try
        {
            CityDto city = await _cityService.GetCity(id);
            return Ok(city);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateCity(CityDto model)
    {
        try
        {
            model = await _cityService.CreateCity(model);
            return CreatedAtAction(nameof(GetCity), new { Id = model.Id }, model);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCity(long id)
    {
        try
        {
            await _cityService.DeleteCity(id);
            return Ok();
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCity(long id, CityDto model)
    {
        try
        {
            model = await _cityService.UpdateCity(id, model);
            return CreatedAtAction(nameof(GetCity), new { Id = model.Id }, model);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

}
