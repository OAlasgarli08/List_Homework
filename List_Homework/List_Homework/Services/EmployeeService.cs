using List_Homework.Datas;
using List_Homework.Models;
using List_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Homework.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public List<Employee> EmployeeBetweenTheseBirthdaysAndChosenSalary(DateTime start, DateTime end)
        {
            return AppDbContext.Employees().Where(m => m.Birthday <= end &&  m.Birthday >= start && m.Salary >= 2000).ToList();
        }
    }
}
