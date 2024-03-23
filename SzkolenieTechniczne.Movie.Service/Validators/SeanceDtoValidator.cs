using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Movie.Service.Dto;

namespace SzkolenieTechniczne.Movie.Service.Validators
{
    internal class SeanceDtoValidator : AbstractValidator<SeanceDto>
    {
        public SeanceDtoValidator()
        {
            RuleFor(x => x.MovieId).NotEmpty();
            RuleFor(x => x.SeanceDate).NotEmpty()
                            .GreaterThan(DateTime.UtcNow);
        }
    }
}
