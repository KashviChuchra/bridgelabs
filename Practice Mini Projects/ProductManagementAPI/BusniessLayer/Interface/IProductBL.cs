using ModelLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Interface
{
    public interface IProductBL
    {
        void AddProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        Product UpdateProduct(int id, Product updatedProduct);
        bool DeleteProduct(int id);
        List<Product> SearchProductByCategory(string category);

    }
}
