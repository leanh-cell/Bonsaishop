using System;
namespace Bercelle.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int id_customer { get; set; }
        public int nameprd { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        public ICollection<Product>? products { get; set; }
        public Customer? Customer { get; set; }
        
    }
}

