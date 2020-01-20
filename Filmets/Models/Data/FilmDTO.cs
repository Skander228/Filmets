using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmets.Models.Data
{
    [Table("tdlFilms")]
    public class FilmDTO
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Producer { get; set; }
        public string ImageName { get; set; }
    }
}