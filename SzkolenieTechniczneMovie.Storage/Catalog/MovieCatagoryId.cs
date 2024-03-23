using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SzkolenieTechniczneMovie.Storage.Common;

namespace SzkolenieTechniczneMovie.Storage.Catalog
{
    [Table("MovieCategories", Schema ="Cinema")]
    internal class MovieCatagoryId : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [MaxLength(32)]
        public string Name { get; set; }
    }
}
