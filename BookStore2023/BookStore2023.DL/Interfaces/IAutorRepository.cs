using BookStore2023.Models.Model;

namespace BookStore2023.DL.Interfaces
{
    public interface IAutorRepository
    {
        void Add(Author author);
        void Delete(int Id);
        Author? GetById(int Id);
        List<Author> GetAll();
        Author? Update(Author author);
    }
}
