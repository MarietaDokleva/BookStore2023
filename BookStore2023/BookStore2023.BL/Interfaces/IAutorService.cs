using BookStore2023.Models.Model;

namespace BookStore2023.BL.Interfaces
{
    public interface IAutorService
    {
            void Add(Author author);
            void Delete(int Id);
            Author? GetById(int Id);
            List<Author> GetAll();
            Author? Update(Author author);
        void Remove(int id);
    }
}
