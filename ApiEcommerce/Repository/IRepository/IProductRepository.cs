using System;
using ApiEcommerce.Models;

namespace ApiEcommerce.Repository.IRepository;

public interface IProductRepository
{
    ICollection<Product> GetProducts();
    ICollection<Product> GetProductsInCategory(int categoryId);
    ICollection<Product> SearchProduct(string name);
    Product? GetProduct(int productId);
    bool BuyProduct(string name, int quantity);
    bool ProductExists(string name);
    bool ProductExists(int productId);
    bool CreateProduct(Product product);
    bool UpdateProduct(Product product);
    bool DeleteProduct(Product product);
    bool Save();
}
