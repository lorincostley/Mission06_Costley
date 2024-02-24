using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Costley.Models
{
    public class Movie
    {
        [Key]
        [Required(ErrorMessage = "MovieID is required.")]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "CategoryID is required.")]

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category CategoryName { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public int Year { get; set; }

        //[Required(ErrorMessage = "Director is required.")]
        public string? Director { get; set; }

        //[Required(ErrorMessage = "Rating is required.")]
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited is required.")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "CopiedToPlex is required.")]
        public int CopiedToPlex { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }
    }
}
