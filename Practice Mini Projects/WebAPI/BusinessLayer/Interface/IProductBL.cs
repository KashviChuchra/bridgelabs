using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;

namespace BusinessLayer.Interface
{
    public interface IProductBL
    {
        Product GetProductById(int id);
        void AddProduct(Product product);
    }
}
