using List_Homework.Services;
using List_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Homework.Controllers
{
    internal class AuthorController
    {
        private readonly IAuthorService _authorService;
        public AuthorController()
        {
            _authorService = new AuthorService();
        }

        public void AuthorOver40()
        {
            var authors = _authorService.ShowAllOlderThanForty();
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + "   ----   " + author.Surname);
            }
        }
    }
}
