using CihanAbay.Models;
using Microsoft.EntityFrameworkCore;
namespace CihanAbay
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        { }

      
      
    }
}
