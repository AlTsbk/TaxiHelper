using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Models
{
    class Trip
    {
        [Key]
        public int Id { get; set; }
        public string FromWhere { get; set; }
        public string Destination { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CarName { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public string State { get; set; }
    }
}
