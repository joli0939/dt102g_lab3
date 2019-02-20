using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class MovieDetail
    {

        // Konstruktor
        public MovieDetail() { }

        // Publika egenskaper
        [Required(ErrorMessage = "Du måste ange ett namn") ]
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Du måste ange en genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Du måste ange en speltid")]
        [Range(5,300, ErrorMessage = "Filmer kan anges mellan 5 och 300 minuter")]
        [Display(Name ="Speltid (Min)")]
        public int Playtime { get; set; }

        [Required(ErrorMessage ="Du måste ange ett årtal")]
        [Range(1800, 2100, ErrorMessage ="Årtal kan anges mellan 1800 och 2100")]
        [Display(Name="Premiärår")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Du måste ange en poäng från IMDB")]
        [Range(0.1, 10, ErrorMessage ="Poängen måste vara mellan 0.1 och 10")]
        [Display(Name = "Poäng på IMDB")]
        public double IMDBScore { get; set; }

        [Required(ErrorMessage ="Du måste ange en Regissör")]
        [Display(Name="Regissör")]
        public string Director { get; set; }

        public int Id { get; set; }
    }
}
