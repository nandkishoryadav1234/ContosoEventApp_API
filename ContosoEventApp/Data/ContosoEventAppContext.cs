using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoEventApp.Models;
using PaymentAPI.Models;

namespace ContosoEventApp.Data
{
    public class ContosoEventAppContext : DbContext
    {
        public ContosoEventAppContext (DbContextOptions<ContosoEventAppContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoEventApp.Models.Booking> Booking { get; set; }

        public DbSet<PaymentAPI.Models.Movie> Movie { get; set; }

        public DbSet<PaymentAPI.Models.PaymentDetails> PaymentDetails { get; set; }

        public DbSet<ContosoEventApp.Models.Show> Show { get; set; }

        public DbSet<ContosoEventApp.Models.User> User { get; set; }
    }
}
