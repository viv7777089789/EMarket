using EMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMarket.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Sales> Sales { get; set; }
    }
}
