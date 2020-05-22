using System;
using System.ComponentModel.DataAnnotations;

namespace Lab21MovieRegistration.Models
{
    public class User
    {

        [MinLength(1, ErrorMessage = "Title Field should allow only 50 characters max")]
        [MaxLength(50, ErrorMessage = "Title Field should allow only 50 characters max")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Range(1880, 2020, ErrorMessage = "Please choose a movie release date within the range 1880 and 2020")]
        public DateTime Date { get; set; }


    }
}
