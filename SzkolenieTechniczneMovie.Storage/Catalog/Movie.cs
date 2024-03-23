using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SzkolenieTechniczneMovie.Storage.Common;

namespace SzkolenieTechniczneMovie.Storage.Catalog
{
    internal class Movie : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required]
        [Range(1900, 3000)]
        public int Year { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(15, 300)]
        public int TimeMinutes { get; set; }

        [Required]
        public long MovieCatagoryId { get; set; }
        [Required]
        public MovieCatagoryId MovieCatagory { get; set; }

        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime ActiveFrom { get; set; }
        [Required]
        public DateTime? ActiveTo { get; set; }

        [Required]
        public ICollection<Seance> Seances { get; set; }

    }
}
