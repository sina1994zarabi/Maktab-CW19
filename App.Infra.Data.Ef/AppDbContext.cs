using App.Domain.Core.Entities;
using App.Infra.Data.Ef.Configuration;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Data.Ef
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigureConnection._connectionString);
        }

    }
}