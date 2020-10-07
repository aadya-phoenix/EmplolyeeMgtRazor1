using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgt.Model
{
    public class Employee
    {
       [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Salary { get; set; }

        public int Mobile { get; set; }
    }
}
