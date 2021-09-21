using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeManagement.Models
{
    //  "a model in MVC contains a set of classes that represent data
    //  and the logic to manage that data"
    // 
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }



    }
}
