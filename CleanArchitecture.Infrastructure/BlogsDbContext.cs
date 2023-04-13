using CleanArchietcture.Core;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure;

public class BlogsDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public BlogsDbContext()
    {
        
    }

    public BlogsDbContext(DbContextOptions<BlogsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // tymczasowe rozwiązanie
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlogsDb;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}