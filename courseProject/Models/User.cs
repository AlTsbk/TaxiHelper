using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Models
{
    class User
    {
        
        public string UserName { get; set; }
        [Key]
        public string Name { get; set; }
        public string position { get; set; }
        public string password { get; set; }

        public string state { get; set; }

        
    }
}
