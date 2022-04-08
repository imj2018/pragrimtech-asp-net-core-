using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {
                new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5},
                new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4},
                new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 },
                new Employee() { ID = 103, Name = "Todd", Salary = 3000, Experience = 3 }
            };

            Employee.PromoteEmployee(employees, employee => employee.Experience >= 5);
        }
    }

    delegate bool IsPromotable(Employee employee);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees, IsPromotable IsEligibleToPromote) //  can use a delegate when you want to pass a function as a parameter
        {
            foreach (Employee employee in employees)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }

        }

        public static bool ExperienceToPromote(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
