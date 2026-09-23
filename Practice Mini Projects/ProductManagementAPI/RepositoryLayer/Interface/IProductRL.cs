using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;

namespace RepositoryLayer.Interface
{
    public interface IProductRL
    {
        void AddProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        Product UpdateProduct(int id, Product updatedProduct);
        bool DeleteProduct(int id);
        List<Product> SearchProductByCategory(string category);

    }
}
