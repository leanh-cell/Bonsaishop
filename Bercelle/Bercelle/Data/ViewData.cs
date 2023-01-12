using System;
using Bercelle.Models;

namespace Bercelle.Data
{
    public class ViewData
    {
        private IEnumerable<Product>? products;
        private IEnumerable<Category>? categories;

        public IEnumerable<Bercelle.Models.Product> Products { get => products!; set => products = value; }
        public IEnumerable<Bercelle.Models.Category> Danhmuc { get => categories!; set => categories = value; }

    }
}

