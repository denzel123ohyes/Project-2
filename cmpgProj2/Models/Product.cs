using System;
using System.Collections.Generic;

namespace cmpgProj2.Models
{
    public partial class Product
    {
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public Guid CategoryId { get; set; }
        public Guid StoreId { get; set; }
        public string? Status { get; set; }
        public bool InStock { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
