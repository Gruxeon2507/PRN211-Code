﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment_3_PT2.Models
{
    public partial class Product
    {
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public float? Price { get; set; }
        public string? Image { get; set; }

    }
}
