using BookStoreApi.DatabaseContext;
using BookStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookStoreApiContext _bookStoreApiContext;
        private  ILogger<BookController> _logger;

        public BookController(BookStoreApiContext bookStoreApiContext, ILogger<BookController> logger)
        {
            _bookStoreApiContext = bookStoreApiContext;
            _logger = logger;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookStoreApiContext.Books;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookStoreApiContext.Books.FirstOrDefault(s => s.Id == id);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _bookStoreApiContext.Books.Add(value);
            _bookStoreApiContext.SaveChanges();
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            var book = _bookStoreApiContext.Books.FirstOrDefault(s => s.Id == id);
            if (book != null)
            {
                _bookStoreApiContext.Entry<Book>(book).CurrentValues.SetValues(value);
                _bookStoreApiContext.SaveChanges();
            }
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bookStore = _bookStoreApiContext.Books.FirstOrDefault(s => s.Id == id);
            if (bookStore != null)
            {
                _bookStoreApiContext.Books.Remove(bookStore);
                _bookStoreApiContext.SaveChanges();
            }
        }
    }
}
