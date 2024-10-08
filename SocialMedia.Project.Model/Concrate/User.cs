using Social.Media.Project.Models.Abstract;
using SocialMedia.Project.Models.Concrate;

namespace Social.Media.Project.Models.Concrate;

public class User : BaseEntity
{
    public virtual UserDetail UserDetail { get; set; }
    public ICollection<Post> Post { get; set; }


}
