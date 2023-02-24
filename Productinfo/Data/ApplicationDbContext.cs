using CRUDApp.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        { }
        public DbSet<Product> Products { get; set; }

    }
}
