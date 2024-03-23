using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Movie.Service.Dto;
using FluentValidation;

namespace SzkolenieTechniczne.Movie.Service.Validators
{
    internal class MovieDtoValidator : AbstractValidator<MovieDto>
    {
        public MovieDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1900, 3000);
            RuleFor(x => x.TimeMinutes).InclusiveBetween(15, 300);

        }
    }
}
