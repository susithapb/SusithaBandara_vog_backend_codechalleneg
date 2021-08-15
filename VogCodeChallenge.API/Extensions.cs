using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Dtos;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API
{
    public static class Extensions
    {
        public static EmployeeDto AsEmpDto(this Employee employee)
        {
            return new EmployeeDto
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address = employee.Address,
                JobTitle = employee.JobTitle,
                DepartmentId = employee.DepartmentId
            };
        }

        public static DepartmentDto AsDeptDto(this Department department)
        {
            return new DepartmentDto
            {
                DepartmentName = department.DepartmentName,
                Address = department.Address
            };
        }

    }
}
