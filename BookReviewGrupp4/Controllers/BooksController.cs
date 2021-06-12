using BookReviewGrupp4.Data;
using BookReviewGrupp4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookReviewContext _bookContext;
        public BooksController(BookReviewContext bookContext)
        {
            _bookContext = bookContext;
        }

        #region Index
        //public IActionResult Index()
        //{
        //    var books = from s in _bookContext.Book
        //                select s;
        //    books = books.OrderByDescending(s => s.Published);
        //    return View(books);
        //}
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var books = from s in _bookContext.Book
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Name.Contains(searchString)
                                       || s.Name.Contains(searchString));
            }
            //if(String.IsNullOrEmpty(searchString) && sortOrder == null)
            //{
            //    books = books.OrderByDescending(s => s.Published);
            //    return View(books);
            //}
            switch (sortOrder)
            {
                case "name_desc":
                    books = books.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    books = books.OrderBy(s => s.Published);
                    break;
                case "date_desc":
                    books = books.OrderByDescending(s => s.Published);
                    break;
                default:
                    books = books.OrderBy(s => s.Name);
                    //books = books.OrderByDescending(s => s.Published);
                    break;
            }

            foreach (var item in books)
            {
                var reviews = _bookContext.Review.Where(b => b.BookId == item.BookId).ToList();
                if (reviews.Count == 0)
                {
                    item.AverageRating = (decimal)0;
                }
                else
                {
                    item.AverageRating = reviews.Sum(x => x.Rating) / reviews.Count;
                }
            }
            await _bookContext.SaveChangesAsync();

            return View(await books.AsNoTracking().ToListAsync());
        } // måste lägga till sortera för genre, author och averagerating
        #endregion

        #region Create
        public IActionResult Create()
        {
            var myViewModel = new ViewModel();
            myViewModel.Authors = new SelectList(GetAuthors(), "AuthorId", "Name");
            return View(myViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId, Name, Genre, Published, Description, AverageRating, AuthorId")] Book book)
        {
            if (ModelState.IsValid)
            {
                _bookContext.Add(book);
                await _bookContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _bookContext.Book
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _bookContext.Book.FindAsync(id);
            _bookContext.Book.Remove(book);
            await _bookContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myViewModel = new ViewModel();
            myViewModel.Book = await _bookContext.Book.FirstOrDefaultAsync(b => b.BookId == id);
            if (myViewModel.Book == null)
            {
                return NotFound();
            }

            myViewModel.Author = _bookContext.Author.FirstOrDefault(a => a.AuthorId == myViewModel.Book.AuthorId);
            myViewModel.Reviews = GetReviews(id).OrderByDescending(d => d.Date).ToList();
            if (myViewModel.Reviews.Count == 0)
            {
                myViewModel.Book.AverageRating = (decimal)0;
            }
            else
            {
                myViewModel.Book.AverageRating = myViewModel.Reviews.Sum(x => x.Rating) / myViewModel.Reviews.Count;
            }
            await _bookContext.SaveChangesAsync();
            return View(myViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewReview(int? bookId, string reviewName, string reviewDescription, int reviewRating)
        {
            if (bookId == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid) // eventuellt inte helt rätt koll här, funkar just nu iaf
            {
                _bookContext.Add(new Review { BookId = (int)bookId, Date = DateTime.Now, Name = reviewName, Description = reviewDescription, Rating = reviewRating });
                await _bookContext.SaveChangesAsync();

                var reviews = _bookContext.Review.Where(b => b.BookId == bookId).ToList();
                var book = _bookContext.Book.FirstOrDefault(b => b.BookId == bookId);
                book.AverageRating = reviews.Sum(x => x.Rating) / reviews.Count;
                await _bookContext.SaveChangesAsync();
            }

            return RedirectToAction("Details", new { id = bookId });
        }
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myViewModel = new ViewModel();
            myViewModel.Book = await _bookContext.Book.FirstOrDefaultAsync(b => b.BookId == id);
            if (myViewModel.Book == null)
            {
                return NotFound();
            }

            myViewModel.Authors = new SelectList(GetAuthors(), "AuthorId", "Name");
            return View(myViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId, Name, Genre, Published, Description, AverageRating, AuthorId")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bookContext.Update(book);
                    await _bookContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        #endregion

        #region Other methods
        private bool BookExists(int id)
        {
            return _bookContext.Book.Any(b => b.BookId == id);
        }
        public IEnumerable<Author> GetAuthors()
        {
            var myAuthors = _bookContext.Author.Select(a => a);
            return myAuthors;
        }
        public IEnumerable<Review> GetReviews(int? id)
        {
            var myReviews = _bookContext.Review.Where(i => i.BookId == id);
            return myReviews;
        }
        #endregion
    }
}
