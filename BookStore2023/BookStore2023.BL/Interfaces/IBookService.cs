using BookStore2023.Models.Model;

namespace BookStore2023.BL.Interfaces
{
    public interface IBookService
    {
        void Add(Book book);
        void Delete(int Id);
        Book GetById(int Id);
        List<Book> GetAll();
        Book? Update(Book book);
        public List<Book>
            GetAllByAuthorAfterReleaseDate(
                int authorId,
                DateTime afterDate);
    }
}
