using List_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Homework.Services.Interfaces
{
    internal interface IEmployeeService
    {
        List<Employee> EmployeeBetweenTheseBirthdaysAndChosenSalary(DateTime start, DateTime end);
    }
}
