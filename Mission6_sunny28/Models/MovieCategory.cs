using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6_sunny28.Models
{
    public class MovieCategory
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
