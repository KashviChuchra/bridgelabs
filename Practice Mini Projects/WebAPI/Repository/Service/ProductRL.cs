using ModelLayer;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Service
{
    public class ProductRL : IProductRL
    {
        private List<Product> products;
        public ProductRL()
        {
            products = new List<Product>
            {
                new Product(1, "Keyboard", 1200m),
                new Product(2, "Mouse", 700m),
                new Product(3, "Monitor", 15000m)
            };

        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public Product GetProductById(int id)
        {
            return products.Find(c => c.Id == id);
        }
    }
}
