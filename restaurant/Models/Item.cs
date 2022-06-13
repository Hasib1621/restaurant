﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace restaurant.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int ItemTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ItemType ItemType { get; set; }
    }
}