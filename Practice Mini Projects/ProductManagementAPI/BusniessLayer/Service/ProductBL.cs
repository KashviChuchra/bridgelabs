using BusniessLayer.Interface;
using ModelLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Service
{
    public class ProductBL : IProductBL
    {
        private IProductRL _productRL;
        public ProductBL(IProductRL _productRL)
        {
            this._productRL = _productRL;
        }
        public void AddProduct(Product product)
        {
            _productRL.AddProduct(product);
        }
        public Product GetProductById(int id)
        {
            return _productRL.GetProductById(id);
        }
        public List<Product> GetAllProducts()
        {
            return _productRL.GetAllProducts();
        }
        public Product UpdateProduct(int id, Product updatedProduct)
        {
            return _productRL.UpdateProduct(id, updatedProduct);
        }
        public bool DeleteProduct(int id)
        {
            return _productRL.DeleteProduct(id);
        }
        public List<Product> SearchProductByCategory(string category)
        {
            return _productRL.SearchProductByCategory(category);
        }
    }
}
