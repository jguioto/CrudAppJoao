using Microsoft.EntityFrameworkCore;
using CrudAppJoao.Models;
using System.Collections.Generic;

namespace CrudAppJoao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}