namespace Social.Media.Project.Models.Concrate;

public class PostComment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
    public int CommentId { get; set; }
    public Comment Comment { get; set; }
}
