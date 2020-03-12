using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ProductCatalog.Model
{
    public interface IProductCatalogService : IService
    {
        Task<Product> GetProductAsync(Guid productId);

        Task<Product[]> GetAllProductsAsync();

        Task AddProductAsync(Product product);
    }
}
