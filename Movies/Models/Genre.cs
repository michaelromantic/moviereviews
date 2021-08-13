﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }

        
        public Genre()
        {

        }
        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}