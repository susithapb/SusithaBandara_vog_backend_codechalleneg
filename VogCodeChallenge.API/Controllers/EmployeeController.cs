using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Interfaces;

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
        public IEnumerable<Employee> GetAll()
        {
            return _repisitory.GetAll();            
        }

        [HttpGet("departments")]
        public IEnumerable<Department> GetDepartments()
        {
            return _repisitory.GetDepartments();
        }

        IList<Employee> ListAll()
        {
            return _repisitory.ListAll();
        }

        [HttpGet("departments/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesByDepartment(int departmentId)
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

            return Ok(_repisitory.GetEmployeesByDepartment(departmentId));
        }
        
    }
}
