using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6_sunny28.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating{ get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }

    }
}


//For the Rating field, use a dropdown menu (G, PG, PG-13, R).
//o For the Edited field, we want that to be a yes/no (true/false) option.
//o The “Edited”, “Lent To”, and “Notes” fields are optional. All other fields must be
//entered.
//o Notes should be limited to 25 characters.