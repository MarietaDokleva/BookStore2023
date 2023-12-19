using BookStore2023.BL.Interfaces;
using BookStore2023.BL.Services;
using BookStore2023.Models.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControler : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookControler(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public Book GetBookById(int id)
        {
            return _bookService.GetById(id);
        }
        [HttpGet(template: "GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }

        [HttpPost]
        public void Add(Book book)
        {
            _bookService.Add(book);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _bookService.Delete(id);
        }
    }
}
    

