using BookStore2023.Models.Model;

namespace BookStore2023.DL.Interfaces
{
    public interface IAutorRepository
    {
        void Add(Autor autor);
        void Delete(int Id);
        Autor? GetById(int Id);
        List<Autor> GetAll();
        Autor? Update(Autor autor);
    }
}
