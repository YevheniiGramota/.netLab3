using FluentValidation;

namespace Lab3.BLL.Models;

public class CityDtoValidation : AbstractValidator<CityDto>
{
    public CityDtoValidation()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
    }
}