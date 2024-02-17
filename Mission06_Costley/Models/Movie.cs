using System.ComponentModel.DataAnnotations;

namespace Mission06_Costley.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Edited is required.")]
        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string Notes { get; set; }
    }
}
