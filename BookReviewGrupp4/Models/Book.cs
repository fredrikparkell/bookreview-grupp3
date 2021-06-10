using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Models
{
    public class Book
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Published { get; set; }
        [Required]
        [MinLength(20)]
        public string Description { get; set; }
        public decimal AverageRating { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
