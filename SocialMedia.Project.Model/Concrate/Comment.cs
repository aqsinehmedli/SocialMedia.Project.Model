using Social.Media.Project.Models.Abstract;

namespace Social.Media.Project.Models.Concrate;

public class Comment : BaseEntity
{
    public string? Comments { get; set; }
    public int LikeCount { get; set; }
    public ICollection<PostComment> PostComments { get; set; }
}
