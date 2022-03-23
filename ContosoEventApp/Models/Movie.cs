using ContosoEventApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

       
        public string MovieName { get; set; }

        
        public string Genre { get; set; }

      
        public string Description { get; set; }

      
        public string Language { get; set; }

       
        public DateTime ReleaseDate { get; set; }

        public int Duretion { get; set; }

        public string Director { get; set; }

        public string Cast { get; set; }

        public string PosterUrl { get; set; }

        
        public virtual ICollection<Show> Shows { get; set; }

    }
}
