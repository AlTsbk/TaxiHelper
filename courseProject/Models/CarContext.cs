using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Models
{
    class CarContext : DbContext
    {
        public CarContext() : base("DefaultConnection")
        { }

        public DbSet<Car> Cars { get; set; }
    }
}
