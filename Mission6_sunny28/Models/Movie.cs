using System;
namespace Mission6_sunny28.Models
{
    public class Movie
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating{ get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

    }
}


//For the Rating field, use a dropdown menu (G, PG, PG-13, R).
//o For the Edited field, we want that to be a yes/no (true/false) option.
//o The “Edited”, “Lent To”, and “Notes” fields are optional. All other fields must be
//entered.
//o Notes should be limited to 25 characters.