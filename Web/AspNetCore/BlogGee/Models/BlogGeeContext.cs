using Microsoft.EntityFrameworkCore;

namespace BlogGee.Models
{
    public class BlogGeeContext : DbContext
    {
        public BlogGeeContext(DbContextOptions<BlogGeeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> Posts { get; set; }
    }
}