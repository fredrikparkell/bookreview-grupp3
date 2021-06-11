using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Models
{
    public class Author
    {
        [Required]
        [Display(Name = "Author")]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        [Display(Name = "Author")]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Display(Name = "Average Rating")]
        public decimal AverageRating { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
