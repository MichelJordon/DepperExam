using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController
    {
        private AuthorService _authorService;

        public AuthorController()
        {
            _authorService = new AuthorService();
        }
        [HttpGet]
        public List<Author> GetAuthors()
        {
            return _authorService.GetAuthors();
        }

        [HttpPost("Insert")]
        public int InsertAuthor(Author author)
        {
            return _authorService.InsertAuthor(author);
        }

        [HttpPut]
        public int UpdateAuthor(Author author)
        {
            return _authorService.UpdateAuthor(author);
        }

        [HttpDelete]
        public int DeleteAuthor(int id)
        {
            return _authorService.DeleteAuthor(id);
        }
        [HttpGet("GetRendomQuotes")]
        public List<Author> GetRendomQuotes()
        {
            return _authorService.GetRendomQuotes();
        }
    }
}