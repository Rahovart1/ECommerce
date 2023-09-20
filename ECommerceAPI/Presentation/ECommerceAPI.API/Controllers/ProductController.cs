using ECommerceAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductReadRepository _readrepository;
        private readonly IProductWriteRepository _writerepository;

        public ProductController(IProductReadRepository readrepository, IProductWriteRepository writerepository)
        {
            _readrepository = readrepository;
            _writerepository = writerepository;
        }

    }
}
