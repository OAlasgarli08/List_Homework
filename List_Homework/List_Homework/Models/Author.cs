using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Homework.Models
{
    internal class Author : BaseEntity
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
