using BookStore2023.BL.Interfaces;
using BookStore2023.DL.Interfaces;
using BookStore2023.Models.Model;

namespace BookStore2023.BL.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }
        public void Add(Author author)
        {
            _autorRepository.Add(author);
        }

        public void Delete(int Id)
        {
            _autorRepository.Delete(Id);
        }

        public List<Author> GetAll()
        {
            return _autorRepository.GetAll();   
        }

        public Author? GetById(int Id)
        {
           return _autorRepository.GetById(Id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Author? Update(Author author)
        {
           return _autorRepository.Update(author);
        }
    }
}
