using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6_sunny28.Models
{
    public class Movie
    {

        //set key for the movie 
        [Key]
        [Required]
        public int MovieId { get; set; }

        //make sure the ones that are required are required
        [Required(ErrorMessage ="Please enter a movie title!")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please enter a valid year!")]
        [Range(1880, 2023)]
        public int Year { get; set; }

        [Required(ErrorMessage ="Please enter the director's name!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a rating!")]
        public string Rating{ get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }

        //limit notes length to 25 characters
        [StringLength(25)]
        public string Notes { get; set; }

        //Build Foreign Key Relationship
        [Required(ErrorMessage ="Please select a category!")]
        public int CategoryId { get; set; }
        public MovieCategory Category { get; set; }
    }
}


//For the Rating field, use a dropdown menu (G, PG, PG-13, R).
//o For the Edited field, we want that to be a yes/no (true/false) option.
//o The “Edited”, “Lent To”, and “Notes” fields are optional. All other fields must be
//entered.
//o Notes should be limited to 25 characters.