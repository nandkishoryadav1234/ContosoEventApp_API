using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }

        public int MovieId { get; set; }

     

        public string MovieName { get; set; }

     

        public string City { get; set; }

        public int ScreenNo { get; set; }

       
        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public double Price { get; set; }

        

       
        public virtual ICollection<Booking> Bookings { get; set; }

        
    }
}
