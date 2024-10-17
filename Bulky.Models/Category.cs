﻿using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "maxlength should be 30")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "should be between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}