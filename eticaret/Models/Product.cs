﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string image { get; set; }
        public bool IsHome { get; set; }
        public bool IsStock { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category category { get; set; }

    }
}
