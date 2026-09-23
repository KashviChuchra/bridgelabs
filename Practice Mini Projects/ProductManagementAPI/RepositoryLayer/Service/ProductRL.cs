using RepositoryLayer.Interface;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Service
{
    public class ProductRL: IProductRL
    {
        private List<Product> products;
        public ProductRL()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public Product GetProductById(int id)
        {
            var product= products.Find(i => i.ProductId == id);
            if (product == null) return null;
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
        public Product UpdateProduct(int id, Product updatedProduct)
        {
            var product = products.Find(p => p.ProductId == id);
            if (product == null)    return null;

            product.ProductName = updatedProduct.ProductName;
            product.Category = updatedProduct.Category;
            product.Quantity = updatedProduct.Quantity;
            product.Price = updatedProduct.Price;

            return product;
        }
        public bool DeleteProduct(int id)
        {
            var product = products.Find(c => c.ProductId == id);
            if (product is null)    return false;
            products.Remove(product);
            return true;
        }

        public List<Product> SearchProductByCategory(string category)
        {
            List<Product> searchedProducts=products.FindAll(c => c.Category == category);
            return searchedProducts;
        }
    }
}
