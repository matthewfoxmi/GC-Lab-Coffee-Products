using System;
using System.Collections.Generic;

namespace Coffee_Shop_Products.Models
{
    public partial class Coffee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? Category { get; set; }
    }
}
