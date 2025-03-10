using Library.Domain.Entities;
using Library.Application.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private ILibraryService libraryService;

        public BookController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }

        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = libraryService.GetBooks();
            return Ok(books);
        }

        // GET: api/books/{id}
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = libraryService.GetBookById(id);
            
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        /*
        // POST: api/books
        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            libraryService.AddBook(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.BookID }, book);
        }

        // PUT: api/books/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            var books = libraryService.GetBooks();
            var existingBook = books.Find(b => b.BookID == id);

            if (existingBook == null)
            {
                return NotFound();
            }

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.IsCheckedOut = book.IsCheckedOut;

            libraryService.AddBook(existingBook);  // Update book

            return NoContent();
        }

        // DELETE: api/books/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var books = libraryService.GetBooks();
            var book = books.Find(b => b.BookID == id);

            if (book == null)
            {
                return NotFound();
            }

            // You would want to implement a delete method in your DAL
            books.Remove(book);

            return NoContent();
        }
        */
    }
}
