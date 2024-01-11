using BookStore2023.DL.Interfaces;
using BookStore2023.DL.MemoryDb;
using BookStore2023.Models.Model;

namespace BookStore2023.DL.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        public void Add(Author author)
        {
            InMemoryDb.Autors.Add(author);
        }

        public void Delete(int Id)
        {
            var autor = GetById(Id);

            if (autor != null)
            {
                InMemoryDb.Autors.Remove(autor);
            }
        }

        public List<Author> GetAll()
        {
            return InMemoryDb.Autors;
        }

        public Author? GetById(int Id)
        {
            return InMemoryDb.Autors.FirstOrDefault(a => a.Id == Id);
        }

        public Author? Update(Author author)
        {
            var result = GetById(author.Id);
            
            if (result != null) 
            {
                InMemoryDb.Autors.Remove(result);
                Add (author);
                return author;
            }
            return null;
        }
    }
}
