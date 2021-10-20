using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.DatabaseContext
{
    public class BookStoreApiContext :DbContext
    {
        public BookStoreApiContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
