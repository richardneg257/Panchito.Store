using Panchito.Store.Entity;
using Panchito.Store.Repository.Interfaces;

namespace Panchito.Store.Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
