using BookStore2023.BL.Interfaces;
using BookStore2023.DL.Interfaces;
using BookStore2023.Models.Model;

namespace BookStore2023.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Delete(int Id)
        {
            _bookRepository.Delete(Id);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetById(int Id)
        {
            return _bookRepository.GetById(Id);
        }

        public Book? Update(Book book)
        {
            return _bookRepository.Update(book);
        }
        public List<Book> GetAllByAuthorAfterReleaseDate
            (int authorId, DateTime afterDate)
        {
            var result =
                _bookRepository.GetAllByAuthor(authorId);

            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }
    }
}
