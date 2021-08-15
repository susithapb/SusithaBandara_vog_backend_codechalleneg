using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Dtos
{
    public class EmployeeDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}
