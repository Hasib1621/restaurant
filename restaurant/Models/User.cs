﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Models
{
    public class User
    {
        public string Name { get; set; }

        [NotMapped]
        public string[] Roles { get; set; }
    }
}