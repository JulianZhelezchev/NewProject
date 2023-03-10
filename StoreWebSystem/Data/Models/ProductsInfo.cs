using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoreWebSystem.Data.Models
{
    public partial class ProductsInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public byte[] ImageContent { get; set; }
        public string ImageMimeType { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }

        public virtual Categories Category { get; set; }
    }
}
