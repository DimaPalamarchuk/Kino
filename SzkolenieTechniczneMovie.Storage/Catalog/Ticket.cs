using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SzkolenieTechniczneMovie.Storage.Common;

namespace SzkolenieTechniczneMovie.Storage.Catalog
{
    class Ticket : BaseEntity
    {
        [Required]
        [MinLength(5)]
        [MaxLength(128)]
        public string Email { get; set; }
        [Required]
        [MinLength(9)]
        [MaxLength(20)]
        public string Phone { get; set; }
        
        [Range(1, 10)]
        public int NumberOfTickets { get; set; }

        [Required]
        public long SeanceId { get; set; }
        public Seance Seance { get; set; }
    }
}
