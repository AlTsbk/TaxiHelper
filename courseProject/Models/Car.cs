using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Models
{
    class Car
    {
        [Key]
        public string CarName { get; set; }
       
        public string CarNumber { get; set; }
        public string YearOfIssue { get; set; }
        public string State { get; set; }
        public string CarLevel { get; set; }

        //public Trip Trip { get; set; }
    }
}
