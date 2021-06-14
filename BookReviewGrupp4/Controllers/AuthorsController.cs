using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookReviewGrupp4.Data;
using BookReviewGrupp4.Models;

namespace BookReviewGrupp4.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly BookReviewContext _context;

        public AuthorsController(BookReviewContext context)
        {
            _context = context;
        }

        #region Index
        // GET: Authors
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = sortOrder == "name_desc" ? "Name" : "name_desc";
            ViewData["CountrySortParm"] = sortOrder == "Country" ? "country_desc" : "Country";
            ViewData["RatingSortParm"] = sortOrder == "rating_desc" ? "Rating" : "rating_desc";
            ViewData["CurrentFilter"] = searchString;

            var authors = _context.Author.Select(a => a);
            if (!String.IsNullOrEmpty(searchString))
            {
                authors = authors.Where(s => s.Name.Contains(searchString)
                                       || s.Name.Contains(searchString));
            }

            foreach (var item in authors)
            {
                var reviews = _context.Review.Where(b => b.Book.AuthorId == item.AuthorId).ToList();
                if (reviews.Count == 0)
                {
                    item.AverageRating = (decimal)0;
                }
                else
                {
                    item.AverageRating = reviews.Sum(x => x.Rating) / reviews.Count;
                }
            }
            await _context.SaveChangesAsync();

            switch (sortOrder)
            {
                case "name_desc":
                    authors = authors.OrderByDescending(s => s.Name);
                    break;
                case "Name":
                    authors = authors.OrderBy(s => s.Name);
                    break;
                case "Country":
                    authors = authors.OrderBy(s => s.Country);
                    break;
                case "country_desc":
                    authors = authors.OrderByDescending(s => s.Country);
                    break;
                case "Rating":
                    authors = authors.OrderBy(s => s.AverageRating);
                    break;
                case "rating_desc":
                    authors = authors.OrderByDescending(s => s.AverageRating);
                    break;
                default:
                    authors = authors.OrderBy(s => s.Name);
                    break;
            }

            return View(await authors.AsNoTracking().ToListAsync());
        }
        #endregion

        #region Create
        // GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorId,Name,Country")] Author author)
        {
            if (ModelState.IsValid)
            {
                _context.Add(author);
                await _context.SaveChangesAsync();
                //if (Request.Path.ToString().Contains("Books/Create"))
                //{
                //    return RedirectToAction("Create", "Books");
                //}
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }
        #endregion

        #region Delete
        // GET: Authors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author
                .FirstOrDefaultAsync(m => m.AuthorId == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var author = await _context.Author.FindAsync(id);
            _context.Author.Remove(author);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Details
        // GET: Authors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myViewModel = new ViewModel();

            myViewModel.Author = await _context.Author
                .FirstOrDefaultAsync(m => m.AuthorId == id);
            if (myViewModel.Author == null)
            {
                return NotFound();
            }

            var reviews = _context.Review.Where(b => b.Book.AuthorId == myViewModel.Author.AuthorId).ToList();
            if (reviews.Count == 0)
            {
                myViewModel.Author.AverageRating = (decimal)0;
            }
            else
            {
                myViewModel.Author.AverageRating = reviews.Sum(x => x.Rating) / reviews.Count;
            }
            await _context.SaveChangesAsync();

            myViewModel.Books = _context.Book.Where(a => a.AuthorId == myViewModel.Author.AuthorId).ToList();

            foreach (var item in myViewModel.Books)
            {
                var bookReviews = _context.Review.Where(b => b.BookId == item.BookId).ToList();
                if (bookReviews.Count == 0)
                {
                    item.AverageRating = (decimal)0;
                }
                else
                {
                    item.AverageRating = reviews.Sum(x => x.Rating) / reviews.Count;
                }
                await _context.SaveChangesAsync();
            }

            return View(myViewModel);
        }
        #endregion

        #region Edit
        // GET: Authors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }
        // POST: Authors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorId,Name,Country")] Author author)
        {
            if (id != author.AuthorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(author);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorExists(author.AuthorId))
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
            return View(author);
        }
        #endregion

        #region Other Methods
        private bool AuthorExists(int id)
        {
            return _context.Author.Any(e => e.AuthorId == id);
        }
        #endregion
    }
}
