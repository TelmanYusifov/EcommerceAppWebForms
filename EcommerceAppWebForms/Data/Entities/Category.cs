﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceAppWebForms.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:30,MinimumLength =3)]
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
    }
}