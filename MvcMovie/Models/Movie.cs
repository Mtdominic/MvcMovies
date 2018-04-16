﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
      
            public int ID { get; set; }

            [StringLength(20, MinimumLength =3)]
            public string Title { get; set; }


            [Display(Name = "Release Date"),DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }

            //[RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
            [Required]
            //[StringLength(30)]
            public string Genre { get; set; }

            //[Range(1,100)]
            //[DataType(DataType.Currency)]
            [Range(1, 100), DataType(DataType.Currency)]
            public decimal Price { get; set; }

            [Required, Range(1, 5)]
            public int Rating { get; set; }
     }

        public class MovieDBContext : DbContext
        {
            public DbSet<Movie> Movies { get; set; }
        }
    }

