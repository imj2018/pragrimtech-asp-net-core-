using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    //  need to inherit from the Controller class in Microsoft.AspNetCore.Mvc
    //  to be able to format json data  
    //
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;


        //  inject the constructor with IEmployeeRepository 
        //
        public HomeController(IEmployeeRepository employeeRepository)
        {
           _employeeRepository = employeeRepository;
        }

        //public JsonResult Index()
        //{
            //return Json(new { Id = 1, name = "Pragim" });

        //}

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
