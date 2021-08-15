using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Interfaces
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll();
        public IList<Employee> ListAll();

        public IEnumerable<Department> GetDepartments();

        public IEnumerable<Employee> GetEmployeesByDepartment(int departmentId);
    }
}
