using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Infrastructure.Implements
{
    public class ProductRepository : IProductsRepository
    {
        private readonly StoreContext _storeContext;

        public ProductRepository(StoreContext storeContext )
        {
            _storeContext = storeContext;
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
            var FindId = await _storeContext.products.FindAsync(id);

            return FindId;
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            var ProdList = await _storeContext.products.ToListAsync();

            return ProdList;
        }
    }
}
