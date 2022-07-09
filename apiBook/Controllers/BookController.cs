using apiBook.Data.Repositories;
using apiBook.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository=bookRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _bookRepository.GetAllBooks());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooksDetail(int id)
        {
            return Ok(await _bookRepository.GetBooksDetail(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            if (book == null)
                return BadRequest();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdBook = await _bookRepository.InsertBook(book);
            return Ok(createdBook);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBook([FromBody] Book book)
        {
            if (book == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _bookRepository.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
           await _bookRepository.DeleteBook(new Book { Id=id});
           return NoContent();
        }
    }
}
