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
        public Autor? GetAutorById(int id)
        {
            return _autorService.GetById(id);
        }
        [HttpGet(template: "GetAllAutor")]
        public List<Autor> GetAllAutor()
        {
            return _autorService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody]Autor autor)
        {
            _autorService.Add(autor); 
        }
        [HttpDelete]
        public void DeleteById(int id)
        {
            _autorService.Remove(id);    
        }
    }
}
