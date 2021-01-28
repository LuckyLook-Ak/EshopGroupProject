﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(1024)]
        public string ProductImage { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public bool Offer { get; set; }
        [RegularExpression(@"^[0-9][0-9]?$|^100$", ErrorMessage ="Must be a percentage from 1 to 100 ")]
        public int? Discount { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int ManufacturerID { get; set; }
        public virtual Manufacturer Manufacturer {get;set;}
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}