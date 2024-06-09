using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductDAO productDAO;
        public ProductRepository()
        {
            productDAO = new ProductDAO();
        }
        public void DeleteProduct(Product p) => productDAO.DeleteProduct(p);

        public Product? GetProductById(int id) => productDAO.GetProductByID(id);

        public List<Product> GetProducts() => productDAO.GetProducts();

        public void SaveProduct(Product p) => productDAO.SaveProduct(p);

        public void UpdateProduct(Product p) => productDAO.UpdateProduct(p);
    }
}
