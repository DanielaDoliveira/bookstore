using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> BooksList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("./Books.db");
        }
    }
}