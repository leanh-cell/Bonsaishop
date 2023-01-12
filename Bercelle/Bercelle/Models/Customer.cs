using System;
namespace Bercelle.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public int? id_oderdetail { get; set; }

        public ICollection<OrderDetail>? orders { get; set; }

    }
}

