using Social.Media.Project.Models.Abstract;

namespace Social.Media.Project.Models.Concrate;

public class Post : BaseEntity
{
    public string? Text { get; set; }
    public int LikeCount { get; set; }
    public ICollection<PostComment> PostComments { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

    public override string ToString() =>
        $"Text:{Text}\nLikeCount:{LikeCount}Users:{User}";
        
        
        }
