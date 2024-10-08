using Social.Media.Project.Models.Concrate;
using SocialMedia.Project.DAL.IRepositories.Abstract;
using SocialMedia.Project.Models.Concrate;

namespace SocialMedia.Project.Main.UnitOfWorks.Abstract;

public interface IUnitOfWork
{
    IRepository<Post> Posts { get; }
    IRepository<Comment> Comments { get; }
    IRepository<User> Users { get; }
    IRepository<UserDetail> UserDeatils { get; }

    int Complete();
}
