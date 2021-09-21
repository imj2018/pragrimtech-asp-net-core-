using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    //  required for depency injection
    //  
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
