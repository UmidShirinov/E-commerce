using API.Infrastructure.DataContext;
using API.Core.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Core.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetDAta()
        {
            var data = await _productsRepository.GetProductsAsync();

            return Ok(data);
         }

        [HttpPost("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            return await _productsRepository.GetProductByIdAsync(id);
        }




    }
}
