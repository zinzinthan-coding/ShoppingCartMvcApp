using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.DAO
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProductDataModel> Products { get; set; }
    }
}
