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
    //  "Controller
    //  Handles the incoming http 
    //  Builds the model And
    //  Returns the Model data to the caller if we are building an API OR
    //  Select a view and pass the model data to the view
    //  The view then generates the required HTML to present the data"
    // 
    public class HomeController : Controller
    {
        //private IEmployeeRepository _employeeRepository;
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


        //  action methods
        //
        //public string Details()
        //public JsonResult Details()
        //public ObjectResult Details()
        //{        
        //    //return _employeeRepository.GetEmployee(1).Name;


        //    Employee model = _employeeRepository.GetEmployee(1);
        //    //return Json(model);
        //    return new ObjectResult(model);
        //}

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            //return View(model);


            //return View("Test");
            //return View("~/MyViews/Test.cshtml");
            //return View("MyViews/Test.cshtml");

            //  by default it looks in the Home folder because the controller name is HomeController
            //  use ../ to move up in the hierarchy to the Views folder, relative path so cshtml is
            //  not needed
            // 
            //return View("../Test/Update");
            //return View("../../MyViews/Test");
            return View();

        }
    }
}
