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

        private readonly IOrderWriteRepository _orderWriteRepository;

        public ProductController(IProductReadRepository readrepository, IProductWriteRepository writerepository, IOrderWriteRepository orderWriteRepository)
        {
            _readrepository = readrepository;
            _writerepository = writerepository;
            _orderWriteRepository = orderWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _orderWriteRepository.AddAsync(new() { Description = "test", Address = "ts" });
            await _orderWriteRepository.AddAsync(new() { Description = "t23est", Address = "ts32" });
            await _orderWriteRepository.SaveAsync();
        }
    }
}
