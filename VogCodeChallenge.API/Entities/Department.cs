using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string Address { get; set; }

    }
}
