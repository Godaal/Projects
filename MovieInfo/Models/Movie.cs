using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieInfo.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a Genre!")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter a Year!")]
        [Range(1950, int.MaxValue, ErrorMessage = "Ivalid Year!")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter a Runtime!")]
        [Range(1,int.MaxValue,ErrorMessage ="Please enter a Runtime!")]
        public int Runtime { get; set; }

        [Required(ErrorMessage = "Please enter a Budget!")]
        public int Budget { get; set; }

        [Required(ErrorMessage = "Please enter a Director!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please enter Stars!")]
        public string Stars { get; set; }

        [Required(ErrorMessage = "Please enter a Country!")]
        public string Country { get; set; }

        public string Story { get; set; }

        [Required(ErrorMessage = "Please enter URL!")]
        [Url(ErrorMessage ="Invalid Url")]
        public string Trailer { get; set; }

        public string ImagePath { get; set; }
    }
}
