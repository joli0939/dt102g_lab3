using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class ActorDetail
    {
        // Konstruktor
        public ActorDetail() { }

        // Publika variabler

        [Required(ErrorMessage = "Du måste ange ett förnamn")]
        [Display(Name = "Förnamn")]
        public string Forename { get; set; }

        [Required(ErrorMessage = "Du måste ange ett efternamn")]
        [Display(Name = "Efternamn")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Då måste ange ett födelsedatum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name ="Födelsedatum (yyyy-mm-dd)")]
        public DateTime DateOfBirth { get; set; }
        public int Id { get; set; }
    }
}
