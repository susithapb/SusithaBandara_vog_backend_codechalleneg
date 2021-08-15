using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Interfaces;

namespace VogCodeChallenge.API.Repositories
{
    public class InMemRepository : IEmployeeRepository
    {
        private readonly List<Department> departments = new List<Department>()
        {
            new Department {Id = 1, DepartmentName="Human Resources", Address="P.O. Box 886 4118 Arcu St.,Rolling Hills Georgia, 92358"},
            new Department {Id = 2, DepartmentName="Finance", Address="P.O. Box 597 4156 Tincidunt Ave, Green Bay Indiana, 19759"},
            new Department {Id = 3, DepartmentName="IT", Address="P.O. Box 508 3919 Gravida St.,Tamuning Washington, 55797"}
        };

        private readonly List<Employee> employees = new List<Employee>()
        {
            new Employee {Id = 1, FirstName="Cecilia", LastName="Chapman", Address="711-2880 Nulla St.Mankato Mississippi 96522", JobTitle="HR Manager", DepartmentId =1},
            new Employee {Id = 2, FirstName="Iris", LastName="Watson", Address="P.O. Box 283 8562 Fusce Rd.Frederick Nebraska 20620", JobTitle="HR Executive", DepartmentId =1},
            new Employee {Id = 3, FirstName="Theodore", LastName="Lowe", Address="Ap #867-859 Sit Rd.Azusa New York 39531", JobTitle="Finance Manager", DepartmentId =2},
            new Employee {Id = 4, FirstName="Calista", LastName="Wise", Address="7292 Dictum Av.San Antonio MI 47096", JobTitle="Accountant", DepartmentId =2},
            new Employee {Id = 5, FirstName="Forrest", LastName="Ray", Address="191-103 Integer Rd.Corona New Mexico 08219", JobTitle="IT Manager", DepartmentId =3},
            new Employee {Id = 6, FirstName="Hiroko", LastName="Potter", Address="P.O. Box 887 2508 Dolor. Av.Muskegon KY 12482", JobTitle="Software Engineer", DepartmentId =3},
            new Employee {Id = 7, FirstName="Lawrence", LastName="Moreno", Address="935-9940 Tortor. StreetSanta Rosa MN 98804", JobTitle="Systems Engineer", DepartmentId =3},

        };

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return departments;
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(int departmentId)
        {
            return employees.Where(employee => employee.DepartmentId == departmentId);
        }

        public IList<Employee> ListAll()
        {
            IList<Employee> employeeList = new List<Employee>();

            foreach (var e in employees)
            {
                employeeList.Add(e);
            }

            return employeeList;

        }

       
    }
}
