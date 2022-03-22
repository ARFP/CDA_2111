using Microsoft.EntityFrameworkCore;
using ApiCereals.Models;

namespace ApiCereals
{
    public class CerealDbContext : DbContext
    {
        public DbSet<Cereal> Cereals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(LocalDB)\mssqllocaldb;Database=dbcereals");
        }
    }
}
