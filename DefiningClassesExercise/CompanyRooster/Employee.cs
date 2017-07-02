using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace CompanyRooster
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        
    }
}
