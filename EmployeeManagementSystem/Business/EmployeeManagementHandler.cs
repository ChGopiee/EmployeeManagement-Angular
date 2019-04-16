//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using EmployeeManagementSystem.Interfaces;
//using EmployeeManagementSystem.Models;

//namespace EmployeeManagementSystem.Business
//{
//    public class EmployeeManagementHandler : IEmployeeManagementHandler
//    {
        
//        public void Add(Employee employee)
//        {
//            EmployeeData.Employees.Add(employee);
//        }

//        public List<Employee> GetEmployees()
//        {
//            return EmployeeData.Employees;
//        }

//        public void Delete(int id)
//        {
//            var employee=EmployeeData.Employees.FirstOrDefault(item => item.Id == id);
//            EmployeeData.Employees.Remove(employee);
//        }

//        public void Update(Employee employee)
//        {
//            var empItem = EmployeeData.Employees.FirstOrDefault(item => item.Id == employee.Id);
//            empItem.Departmet = employee.Departmet;
//            empItem.EmployeeName = empItem.EmployeeName;
//            empItem.Salary = empItem.Salary;
//        }
//    }
//}