namespace CleanArchietcture.Core;

public class Post
{
    public int PostId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
}
