using System;
namespace Bercelle.Models
{
    public class Category
    {
        public int id { get; set; }
        public string? namectg { get; set; }

        public ICollection<Product>? products { get; set; }
    }
}

