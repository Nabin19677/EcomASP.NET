using ecom_web_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecom_web_api.Extensions
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}



























