using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Movie.Service.Dto
{
    internal class SeanceDto
    {
        public Guid MovieId {  get; set; }
        public DateTime SeanceDate { get; set; }
    }
}
