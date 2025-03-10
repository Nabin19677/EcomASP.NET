using ecom_web_api.entities;
using Microsoft.EntityFrameworkCore;

namespace ecom_web_api.extensions
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}



























