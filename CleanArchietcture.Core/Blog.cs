namespace CleanArchietcture.Core;
// POCO
public class Blog
{
    public int BlogId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public ICollection<Post> Posts { get; set;} = new List<Post>();

}