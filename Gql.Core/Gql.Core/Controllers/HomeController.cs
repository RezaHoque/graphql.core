using Gql.Core.Models;
using Gql.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gql.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthorRepository _authorRepo;
        private readonly IBookRepository _bookRepo;

        public HomeController(IAuthorRepository authorRepo, IBookRepository bookRepo)
        {
            _authorRepo = authorRepo;
            _bookRepo = bookRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
