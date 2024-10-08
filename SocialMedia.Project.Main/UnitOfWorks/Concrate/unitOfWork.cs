using Social.Media.Project.Models.Concrate;
using SocialMedia.Project.DAL.Context;
using SocialMedia.Project.DAL.IRepositories.Abstract;
using SocialMedia.Project.DAL.IRepositories.Concrate;
using SocialMedia.Project.Main.UnitOfWorks.Abstract;
using SocialMedia.Project.Models.Concrate;

namespace SocialMedia.Project.Main.UnitOfWorks.Concrate;

public class unitOfWork : IUnitOfWork
{
    private readonly SocialMediaDbContext _context;
    public IRepository<Post> Posts { get; }
    public IRepository<Comment> Comments { get; }
    public IRepository<UserDetail> UserDetails { get; }
    public IRepository<User> Users { get; }

    public IRepository<UserDetail> UserDeatils => throw new NotImplementedException();

    public unitOfWork(SocialMediaDbContext context)
    {
        _context = context;

        Posts = new BaseRepository<Post>(_context);
        Comments = new BaseRepository<Comment>(_context);
        Users = new BaseRepository<User>(_context);
        UserDetails = new BaseRepository<UserDetail>(_context);
    }
    public int Complete()
    {
        return _context.SaveChanges();
    }
    public void Dispose() 
    {
        _context.Dispose();
    }

}
