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
        //  when the IEmployeeRepository service requested we want to an instance of MockEmployeeRepository 
        //  to be created and injected into the controller, ASP.NET Core cannot do this by default so the 
        //  interface IEmployeeRepository and its implementation MockEmployeeRepository have to be registered
        //  in Startup
        // 
        public HomeController(IEmployeeRepository employeeRepository)
        {
            //  would cause coupling, difficult to change if there were multiple controllers
            //
            //_employeeRepository = new MockEmployeeRepository();

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
