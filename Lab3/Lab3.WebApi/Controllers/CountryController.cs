using Lab3.BLL.Models;
using Lab3.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.WebApi.Controllers;

public class CountryController : ApiControllerBase
{
    private readonly ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCountries()
    {
        IEnumerable<CountryDto> countries = await _countryService.GetCountries();
        return Ok(countries);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCountry(long id)
    {
        try
        {
            CountryDto country = await _countryService.GetCountry(id);
            return Ok(country);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateCountry(CountryDto model)
    {
        try
        {
            model = await _countryService.CreateCountry(model);
            return CreatedAtAction(nameof(GetCountry), new { Id = model.Id }, model);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCountry(long id)
    {
        try
        {
            await _countryService.DeleteCountry(id);
            return Ok();
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCountry(long id, CountryDto model)
    {
        try
        {
            model = await _countryService.UpdateCountry(id, model);
            return CreatedAtAction(nameof(GetCountry), new { Id = model.Id }, model);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}
