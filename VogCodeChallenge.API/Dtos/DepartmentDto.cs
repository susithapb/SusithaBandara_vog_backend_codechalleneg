using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Dtos
{
    public class DepartmentDto
    {
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
