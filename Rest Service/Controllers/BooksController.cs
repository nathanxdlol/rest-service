using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestService
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksManager _manager = new BooksManager();
        // get api books controller
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }
        [HttpGet("{ISPN13}")]
        public Book Get(string ISPN13)
        {
            return _manager.GetByISBN13(ISPN13);
        }
        // post api books controller
        [HttpPost]
        public Book Post( Book value)
        {
            return _manager.Add(value);
        }
        // DELETE api/<BooksController>/5
        [HttpDelete("{ISPN13}")]
        public Book Delete(string ISPN13)
        {
            return _manager.Delete(ISPN13);
        }
    }
}
