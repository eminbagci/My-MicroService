using Book.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController:ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService= bookService;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookService.Getlist());
        }
    }
}
