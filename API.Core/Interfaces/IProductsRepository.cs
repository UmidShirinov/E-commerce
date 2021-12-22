using API.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IProductsRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<List<Product>> GetProductsAsync();
        Task<List<ProductBrand>> GetProductBrandAsync();
        Task<List<ProductType>> GetProductTypeAsync();
    }
}
