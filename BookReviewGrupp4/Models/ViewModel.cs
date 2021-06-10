using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Models
{
    public class ViewModel
    {
        public Book Book { get; set; }
        public SelectList Authors { get; set; }
        public List<Review> Reviews { get; set; }
        public Author Author { get; set; }
        public List<Book> Books { get; set; }
    }
}
