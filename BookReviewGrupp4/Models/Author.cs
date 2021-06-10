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
        public int AuthorId { get; set; }


        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
