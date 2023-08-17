using Microsoft.EntityFrameworkCore;
using UserTasks.Models;

namespace UserTasks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }


        public DbSet<User> Users { get; set; }
        
    }
}
