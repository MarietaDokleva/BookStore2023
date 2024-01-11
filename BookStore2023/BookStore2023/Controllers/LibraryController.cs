using BookStore2023.BL.Interfaces;
using BookStore2023.Models.Requests;
using BookStore2023.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStore2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetAllBooksByAuthorAndDate")]
        public GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAndDate([FromBody]
                GetAllBooksByAuthorRequest request)
        {
            return _libraryService
                .GetAllBooksByAuthorAfterReleaseDate(request);
        }
    }
}
