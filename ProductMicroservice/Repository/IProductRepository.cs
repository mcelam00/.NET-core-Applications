using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroservice.Models;



namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int product);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }
}
