using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ProductCatalog.Model
{
    public interface IProductRepository
    {
        Task<Product> GetProduct(Guid productId);

        Task<IEnumerable<Product>> GetAllProducts();

        Task AddProduct(Product product);
    }
}
