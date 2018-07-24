using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductProject.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        [Display(Name="Number in stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}