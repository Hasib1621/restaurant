﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Models
{
    public class Role : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
