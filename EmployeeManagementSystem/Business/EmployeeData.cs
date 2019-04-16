using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Business
{
    public sealed class EmployeeData
    {
        private static List<Employee> Employees { get; set; }
        public static List<Employee> GetEmployees()
        {
            if (  Employees == null )
                {
                    return new List<Employee>
                    {
                        new Employee
                        {
                            Salary = "67000",
                            Id = 1,
                            EmployeeName = "John",
                            Departmet = new Department {DepartmentId = 1, DepartmentName = "IT"}
                        },
                        new Employee
                        {
                            Salary = "67000",
                            Id = 2,
                            EmployeeName = "Hopkins",
                            Departmet = new Department {DepartmentId = 1, DepartmentName = "IT"}
                        },
                        new Employee
                        {
                            Salary = "67000",
                            Id = 3,
                            EmployeeName = "David",
                            Departmet = new Department {DepartmentId = 1, DepartmentName = "IT"}
                        },
                        new Employee
                        {
                            Salary = "67000",
                            Id = 4,
                            EmployeeName = "Amanda",
                            Departmet = new Department {DepartmentId = 1, DepartmentName = "IT"}
                        },
                        new Employee
                        {
                            Salary = "68000",
                            Id = 5,
                            EmployeeName = "Ramesh",
                            Departmet = new Department {DepartmentId = 1, DepartmentName = "IT"}
                        },
                        new Employee
                        {
                            Salary = "69000",
                            Id = 6,
                            EmployeeName = "Suresh",
                            Departmet = new Department {DepartmentId = 1, DepartmentName = "IT"}
                        },
                        new Employee
                        {
                            Salary = "66000",
                            Id = 7,
                            EmployeeName = "Shruthi",
                            Departmet = new Department {DepartmentId = 2, DepartmentName = "HR"}
                        },
                        new Employee
                        {
                            Salary = "69000",
                            Id = 8,
                            EmployeeName = "Mahesh",
                            Departmet = new Department {DepartmentId = 2, DepartmentName = "HR"}
                        },
                        new Employee
                        {
                            Salary = "65000",
                            Id = 9,
                            EmployeeName = "Sujesh",
                            Departmet = new Department {DepartmentId = 2, DepartmentName = "HR"}
                        },
                        new Employee
                        {
                            Salary = "64000",
                            Id = 10,
                            EmployeeName = "Karthik",
                            Departmet = new Department {DepartmentId = 2, DepartmentName = "HR"}
                        },
                        new Employee
                        {
                            Salary = "62000",
                            Id = 11,
                            EmployeeName = "Abhinay",
                            Departmet = new Department {DepartmentId = 2, DepartmentName = "HR"}
                        },
                        new Employee
                        {
                            Salary = "61000",
                            Id = 12,
                            EmployeeName = "Sunil",
                            Departmet = new Department {DepartmentId = 2, DepartmentName = "HR"}
                        }
                    };
                }
            return Employees;
        }



    }
}