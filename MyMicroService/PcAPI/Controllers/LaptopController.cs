using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pc.Business.Abstract;

namespace PcAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopController : ControllerBase
    {
        private readonly ILaptopService _laptopService;
        public LaptopController(ILaptopService laptopService)
        {
            _laptopService = laptopService;
        }
        [HttpGet]
        public IActionResult GetLaptops()
        {
            return Ok(_laptopService.GetList());
        }
    }
}
