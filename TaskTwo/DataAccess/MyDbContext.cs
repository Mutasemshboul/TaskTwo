using Microsoft.EntityFrameworkCore;
using TaskTwo.Models;

namespace TaskTwo.DataAccess
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> myContext) : base(myContext)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
