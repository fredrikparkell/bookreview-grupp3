using BookReviewGrupp4.Data;
using BookReviewGrupp4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookReviewContext _bookContext;

        public HomeController(ILogger<HomeController> logger, BookReviewContext bookContext)
        {
            _logger = logger;
            _bookContext = bookContext;
        }

        public IActionResult Index()
        {
            
            var books = from s in _bookContext.Book
                        orderby s.AverageRating descending
                        select s;


            return View(books);
            
            
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
