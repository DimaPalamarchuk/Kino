using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Movie.Service.Validators;

namespace SzkolenieTechniczne.Movie.Service.Dto
{
    internal class MovieDto : MovieDtoValidator
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int TimeMinutes { get; set; }
        public string Description { get; set; }
    }
}
