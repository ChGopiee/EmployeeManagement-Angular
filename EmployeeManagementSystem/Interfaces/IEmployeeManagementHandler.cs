using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeManagementHandler
    {
        void Add(Employee employee);
        List<Employee> GetEmployees();
        void Delete(int id);
        void Update(Employee employee);
    }
}
