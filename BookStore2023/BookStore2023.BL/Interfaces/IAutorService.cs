using BookStore2023.Models.Model;

namespace BookStore2023.BL.Interfaces
{
    public interface IAutorService
    {
            void Add(Autor autor);
            void Delete(int Id);
            Autor? GetById(int Id);
            List<Autor> GetAll();
            Autor? Update(Autor autor);
        void Remove(int id);
    }
}
