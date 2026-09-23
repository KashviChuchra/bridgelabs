using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;

namespace Repository.Interface
{
    public interface IProductRL
    {
        Product GetProductById(int id);
        void AddProduct(Product product);
    }

    
}
