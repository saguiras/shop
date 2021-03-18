using Microsoft.EntityFrameworkCore;
using Models;

namespace shop.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Products> Products {get; set;}
        public DbSet<Products_description> Products_Description { get; set;}
        public DbSet<Customers> Customers { get; set;}
        //public DbSet<Customers_Description> Customers_Description { get; set;}
        public DbSet<Orders> Orders { get; set;}
    }
}