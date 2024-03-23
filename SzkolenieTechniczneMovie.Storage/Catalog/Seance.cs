using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SzkolenieTechniczneMovie.Storage.Common;

namespace SzkolenieTechniczneMovie.Storage.Catalog
{
    class Seance : BaseEntity
    {
        [Required]
        public DateTime Data { get; set; }
        [Required]

        public int NumberOfTickets { get; set; }

        [Required]
        public long MovieId { get; set; }
        [Required]
        public Movie Movie { get; set; } // Key
        [Required]
        public ICollection<Ticket> Tickets { get; set; }
    }
}
