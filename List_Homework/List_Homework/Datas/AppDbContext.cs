using List_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Homework.Datas
{
    internal class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>
            {
                new Author {Id = 1, Age = 50, FirstName = "Person1 Name", Surname = "Person1 Surname"},
                new Author {Id = 2, Age = 20, FirstName = "Person2 Name", Surname = "Person2 Surname"},
                new Author {Id = 3, Age = 60, FirstName = "Person3 Name", Surname = "Person3 Surname"}
            };
        }

        public static List<Employee> Employees()
        {
            return new List<Employee>
            {
                new Employee {Id = 1, Name = "Person 1", Surname = "Surname 1", Salary = 2000, Birthday = new DateTime(2007,10,10) },
                new Employee {Id = 1, Name = "Person 2", Surname = "Surname 2", Salary = 4000, Birthday = new DateTime(2012,12,05) },
                new Employee {Id = 1, Name = "Person 3", Surname = "Surname 3", Salary = 6000, Birthday = new DateTime(2010,08,12) },
            };
        }

        public static List<Product> Products()
        {
            return new List<Product>
            {
                new Product {Id = 1, Amount = 50, Name = "Mango", Price = 5},
                new Product {Id = 2, Amount = 10, Name = "Dragon Fruit", Price = 50},
                new Product {Id = 3, Amount = 100, Name = "Apple", Price = 1}
            };
        }
    }
}
