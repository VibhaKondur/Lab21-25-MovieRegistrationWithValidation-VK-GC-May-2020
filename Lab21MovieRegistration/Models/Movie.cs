using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21MovieRegistration.Models
{
    public class Movie
    {
        //1. Create a Movie model with the following properties:
        //ID
        //Title
        //Genre
        //Year
        //Actors
        //Directors

        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
