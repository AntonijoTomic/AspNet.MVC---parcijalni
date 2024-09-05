using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        private List<Book> _books;

        public ExamController()
        {
           
               
            

        }
        public IActionResult Index()
        {
                _books = new List<Book>();

                Author autor1 = new Author() { Id = 1, Name = "Wiliam", Surname = "Shakespeare", Nationality = "Bosnian" };
                Author autor2 = new Author() { Id = 2, Name = "Antonijo", Surname = "Tomić", Nationality = "Croatian" };
                Author autor3 = new Author() { Id = 3, Name = "Ratko", Surname = "Ćosić", Nationality = "Croatian" };

                _books.Add(new Book() { Author = autor1, Id = 1, Title = "Hamlet", NumberOfPages = 300 });
                _books.Add(new Book() { Author = autor2, Id = 2, Title = "How to become a bad programmer", NumberOfPages = 1 });
                _books.Add(new Book() { Author = autor3, Id = 3, Title = "What is it like to be the best lecturer?", NumberOfPages = 999 });
                _books.Add(new Book() { Author = autor3, Id = 4, Title = "ASP NET", NumberOfPages = 123 });
                _books.Add(new Book() { Author = autor1, Id = 5, Title = "Romeo AND Juliet", NumberOfPages = 500 });
                return View(_books);
        }
    }
}
