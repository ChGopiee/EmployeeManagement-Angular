using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagementSystem.Business;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeManagementController : Controller
    {
        private readonly IEmployeeManagementHandler _handler;

        //public EmployeeManagementController(IEmployeeManagementHandler handler)
        //{
        //    _handler = handler;
        //}
        public EmployeeManagementController() { }
        // GET: EmployeeManagement
        public JsonResult Index()
        {
            return Json(EmployeeData.GetEmployees(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(Employee employee)
        {
            _handler.Add(employee);
            return Json(_handler.GetEmployees(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Employee employee)
        {
            _handler.Update(employee);
            return Json(_handler.GetEmployees(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
           _handler.Delete(id);
            return Json(_handler.GetEmployees(), JsonRequestBehavior.AllowGet);
        }
    }
}