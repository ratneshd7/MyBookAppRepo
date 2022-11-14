using API.Services.Interface;
using Data.MyBookApp;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/v1/MyBook")]
    public class MyBookController : Controller
    {
        private readonly IBookService _bookService;
        public MyBookController(IBookService bookService)
        {
            _bookService=bookService;
        }
        /// <summary>
        /// Get Book by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("book")]
        public async Task<IActionResult> GetBook(Guid id)
        {
            try
            {  
                var result = await _bookService.GetBook(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get List Of Book
        /// </summary>
        /// <returns></returns>
        [HttpGet("books")]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                var result = await _bookService.GetBooks();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddBook")]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            try
            {
                var result = await _bookService.AddBook(book);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
