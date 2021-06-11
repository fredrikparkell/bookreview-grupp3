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
        public async Task<IActionResult> Index()
        {
            var authors = await _context.Author.ToListAsync();

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

            return View(await _context.Author.ToListAsync());
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

            myViewModel.Books = _context.Book.Where(a => a.AuthorId == myViewModel.Author.AuthorId).ToList();

            foreach (var item in myViewModel.Books)
            {
                var bookReviews = _context.Review.Where(b => b.BookId == item.BookId).ToList();
                item.AverageRating = reviews.Sum(x => x.Rating) / reviews.Count;
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
