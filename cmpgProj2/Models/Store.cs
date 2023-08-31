using System;
using System.Collections.Generic;

namespace cmpgProj2.Models
{
    public partial class Store
    {
        public Guid StoreId { get; set; }
        public string StoreName { get; set; } = null!;
        public string? StoreDescription { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
