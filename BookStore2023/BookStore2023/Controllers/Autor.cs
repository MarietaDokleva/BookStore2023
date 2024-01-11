using BookStore2023.BL.Interfaces;
using BookStore2023.Models.Model;
using Microsoft.AspNetCore.Mvc;
namespace BookStore2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorControler : ControllerBase
    {
        private readonly IAutorService _autorService;
        public AutorControler(IAutorService autorService)
        {
            _autorService = autorService;
        }
        [HttpGet]
        public Author? GetAutorById(int id)
        {
            return _autorService.GetById(id);
        }
        [HttpGet(template: "GetAllAutor")]
        public List<Author> GetAllAutor()
        {
            return _autorService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody]Author author)
        {
            _autorService.Add(author); 
        }
        [HttpDelete]
        public void DeleteById(int id)
        {
            _autorService.Remove(id);    
        }
    }
}
