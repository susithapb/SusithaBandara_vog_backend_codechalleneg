using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Interfaces;

namespace VogCodeChallenge.API.Repositories
{
    public class StoreContextRepository : IEmployeeRepository
    {
        private readonly StoreContext _context;

        public StoreContextRepository(StoreContext context)
        {
            _context = context;
        }

        /** To handle EF operations asyncronasly
        
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByDepartment(int departmentId)
        {
            return await _context.Employees.Where(employee => employee.DepartmentId == departmentId).ToListAsync();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }    

        */

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments.ToList();
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployeesByDepartment(int departmentId)
        {
            return _context.Employees.Where(employee => employee.DepartmentId == departmentId).ToList();
        }

        public IList<Employee> ListAll()
        {
            IList<Employee> employeeList = _context.Employees.ToList();
            return employeeList;
        }
    }
}
