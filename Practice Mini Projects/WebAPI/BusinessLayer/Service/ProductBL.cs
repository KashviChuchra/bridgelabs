using BusinessLayer.Interface;
using Repository.Interface;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class ProductBL : IProductBL
    {
        private IProductRL _product;
        public ProductBL(IProductRL product)
        {
            _product = product;
        }
        public Product GetProductById(int id)
        {
            return _product.GetProductById(id);
        }
        public void AddProduct(Product product)
        {
            _product.AddProduct(product);
        }
    }
}
