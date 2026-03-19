using Microsoft.EntityFrameworkCore;
using HouseApi.Models;

namespace HouseApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}