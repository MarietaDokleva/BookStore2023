using BookStore2023.DL.Interfaces;
using BookStore2023.DL.MemoryDb;
using BookStore2023.Models.Model;

namespace BookStore2023.DL.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        public void Add(Autor autor)
        {
            InMemoryDb.Autors.Add(autor);
        }

        public void Delete(int Id)
        {
            var autor = GetById(Id);

            if (autor != null)
            {
                InMemoryDb.Autors.Remove(autor);
            }
        }

        public List<Autor> GetAll()
        {
            return InMemoryDb.Autors;
        }

        public Autor? GetById(int Id)
        {
            return InMemoryDb.Autors.FirstOrDefault(a => a.Id == Id);
        }

        public Autor? Update(Autor autor)
        {
            var result = GetById(autor.Id);
            
            if (result != null) 
            {
                InMemoryDb.Autors.Remove(result);
                Add (autor);
                return autor;
            }
            return null;
        }
    }
}
