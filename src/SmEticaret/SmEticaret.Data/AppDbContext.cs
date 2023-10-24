using Microsoft.EntityFrameworkCore;
using SmEticaret.Data.Entities;

namespace SmEticaret.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // DbSet'ler....
        public DbSet<UserEntity> Users { get; set; }
        //...
    }
}
