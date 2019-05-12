using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Models
{
    class TripContext : DbContext
    {
        public TripContext() : base("DefaultConnection")
        { }

        public DbSet<Trip> Trips { get; set; }
    }
}
