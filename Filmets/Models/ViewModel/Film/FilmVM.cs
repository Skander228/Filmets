using Filmets.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmets.Models.ViewModel.Film
{
    public class FilmVM
    {
        public FilmVM()
        { 
            
        }

        public FilmVM(FilmDTO row)
        {
            Id = row.Id;
            MovieName = row.MovieName;
            Description = row.Description;
            Year = row.Year;
            Producer = row.Producer;
            ImageName = row.ImageName;
        }

        [DisplayName("Номер")]
        public int Id { get; set; }
        [DisplayName("Название")]
        [Required]
        public string MovieName { get; set; }
        [DisplayName("Описание")]
        [Required]
        public string Description { get; set; }
        [DisplayName("Год")]
        [Required]
        public int Year { get; set; }
        [DisplayName("Режиссер")]
        [Required]
        public string Producer { get; set; }
        [DisplayName("Картинка")]
        [Required]
        public string ImageName { get; set; }
    }
}