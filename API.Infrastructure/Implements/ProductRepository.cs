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

        public async Task<List<ProductBrand>> GetProductBrandAsync()
        {
            return await _storeContext.ProductBrand.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var FindId = await _storeContext.products.FirstOrDefaultAsync(p=>p.Id == id);

            return FindId;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var ProdList = await _storeContext.products.
                Include(p=>p.ProductBrand).
                Include(p=>p.ProducType)
                .ToListAsync();

            return ProdList;
        }

        public  async Task<List<ProductType>> GetProductTypeAsync()
        {
            var data = await _storeContext.ProductType.ToListAsync();

            return data;
        }
    }
}
