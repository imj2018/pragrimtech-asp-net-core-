using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {
                new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 },
                new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 },
                new Employee() { ID = 103, Name = "JohN", Salary = 6000, Experience = 6 },
                new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 }
            };

            //Employee anonymous = employees.Find(delegate(Employee e) { return e.ID == 102 });
            //Employee employee = employees.Find((Employee x) => x.ID == 102); //  input parameter, such that/goes to expression
            Employee employee = employees.Find(e => e.ID == 102);

            Console.WriteLine(employee.ID + " " + employee.Name);

            int count = employees.Count(e => e.Name.ToLower().EndsWith("n"));
            string name = employees.Find(e => e.Name.ToLower().EndsWith("n")).Name;

            Console.WriteLine(count);
            Console.WriteLine(name);



        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

    }


}
