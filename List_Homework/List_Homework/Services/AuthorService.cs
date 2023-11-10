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
    internal class AuthorService : IAuthorService
    {
        public List<Author> ShowAllOlderThanForty()
        {
            return AppDbContext.Authors().Where(m => m.Age >= 40).ToList();
        }
    }
}
