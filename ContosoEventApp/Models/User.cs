using ContosoEventApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


       
        public string FirstName { get; set; }


        
        public string LastName { get; set; }

    

        public string UserName { get; set; }

       
        public string Password { get; set; }


        public string Gender { get; set; }

        
        public string MobileNo { get; set; }


       
        public string Email { get; set; }

        public string Address { get; set; }

       
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
