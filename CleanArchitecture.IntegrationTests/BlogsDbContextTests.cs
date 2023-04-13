using CleanArchietcture.Core;
using CleanArchitecture.Infrastructure;

namespace CleanArchitecture.IntegrationTests;

public class BlogsDbContextTests
{
    [Fact]
    public async Task AddingBlogTest()
    {
        using var db = new BlogsDbContext();

        var blog = new Blog { Name = "Blog 1", Author = "Bartek" };
        db.Add(blog);
        int rowsAffected = await db.SaveChangesAsync();

        Assert.Equal(1, rowsAffected);
    }
}