using API.Data.DataContext;
using API.Data.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private StoreContext _storeContext { get; set; }


        public ProductsController(StoreContext storeContext )
        {

            _storeContext = storeContext;

        }

        [HttpGet]
        public List<Product> GetDAta()
        {
            var data = _storeContext.Products.ToList();



            return data;
        }
    }
}
