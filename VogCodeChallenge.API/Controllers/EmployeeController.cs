using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Dtos;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Interfaces;
using VogCodeChallenge.API.Repositories;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repisitory;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repisitory = repository;
        }
         

        [HttpGet]
        public IEnumerable<EmployeeDto> GetAll()
        {
            var employees = _repisitory.GetAll().Select(employee => employee.AsEmpDto());
            return employees;
        }

       
        [HttpGet("departments")]
        public IEnumerable<DepartmentDto> GetDepartments()
        {
            var departments =  _repisitory.GetDepartments().Select(department => department.AsDeptDto());
            return departments;
        }

        IList<Employee> ListAll()
        {
            return _repisitory.ListAll();
        }

        [HttpGet("departments/{departmentId}")]
        public ActionResult<IEnumerable<EmployeeDto>> GetEmployeesByDepartment(int departmentId)
        {
            var departmentList = _repisitory.GetDepartments();
            Boolean temp = false;

            foreach (var d in departmentList)
            {
                if (departmentId == d.Id)
                {
                    temp = true;
                }
            }

            if(!temp)
            {
                return NotFound();
            }

            return Ok(_repisitory.GetEmployeesByDepartment(departmentId).Select(employee => employee.AsEmpDto()));
        }
        
    }
}
