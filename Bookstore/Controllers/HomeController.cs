using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;
using System.Collections.Generic;
using Bookstore.Data;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookstoreContext _context;

        public HomeController(BookstoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Retrieve the list of books from the database
            IEnumerable<Book> books = _context.Books;

            // Pass the list of books to the view
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
