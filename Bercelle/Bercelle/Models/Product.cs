using System;
namespace Bercelle.Models
{
    public class Product
    {
        public int id { get; set; }
        public string? namectg { get; set; }
        public byte image { get; set; }
        public string? nameprd { get; set; }
        public float price { get; set; }
        public string? description { get; set; }
        public int quantity { get; set; }

        public ICollection<Category>? categories { get; set; }
    }
}
