using List_Homework.Services;
using List_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Homework.Controllers
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void ChosenEmployees()
        {
            var employees = _employeeService.EmployeeBetweenTheseBirthdaysAndChosenSalary(new DateTime(2009, 01, 01), new DateTime(2011, 01, 01));
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} + {employee.Surname} + {employee.Salary} + {employee.Birthday} ");
            }
        }
    }
}
