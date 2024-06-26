﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string? Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(30), Required, RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)"), DataType(DataType.Currency), Range(1, 100)]
        public decimal Price { get; set; }

        [StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required]
        public string? Rating { get; set; }
        public string? ImageName { get; set; }
    }
}
