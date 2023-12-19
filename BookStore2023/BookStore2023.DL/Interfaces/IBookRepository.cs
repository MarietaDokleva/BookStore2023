using BookStore2023.Models.Model;

namespace BookStore2023.DL.Interfaces
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Delete(int Id);
        Book? GetById(int Id);
        List<Book> GetAll();
        Book? Update(Book book);
    }
}
