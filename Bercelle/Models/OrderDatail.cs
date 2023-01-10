using System;
using System.ComponentModel.DataAnnotations;

namespace Bercelle.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int id_customer { get; set; }
        public string? nameprd { get; set; }
        public double price { get; set; }
        [DataType(DataType.Date)]
        public DateTime datemh { get; set; }
        public string? status { get; set; }
        public DateTime dategh { get; set; }
        public DateTime? datenh { get; set; }

        public Cart? Customer { get; set; }
    }
}

