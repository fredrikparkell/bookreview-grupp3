using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Models
{
    public class Review
    {
        [Required]
        public int ReviewId { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [Range(1,5)]
        public decimal Rating { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime Date { get; set; }

        
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
