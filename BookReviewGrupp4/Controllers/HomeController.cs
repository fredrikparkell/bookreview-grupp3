using BookReviewGrupp4.Data;
using BookReviewGrupp4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var myViewModel = new ViewModel();
            myViewModel.Books = _bookContext.Book.OrderByDescending(b => b.AverageRating).Take(8).ToList();
            myViewModel.AuthorsList = _bookContext.Author.OrderByDescending(a => a.AverageRating).Take(8).ToList();
            myViewModel.Reviews = _bookContext.Review.Include(r => r.Book).OrderByDescending(b => b.Date).Take(5).ToList();

            return View(myViewModel); 
        }

        public IActionResult About()
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
