using FluentValidation;

namespace Lab3.BLL.Models;

public class CountryDtoValidation : AbstractValidator<CountryDto>
{
    public CountryDtoValidation()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);
    }
}