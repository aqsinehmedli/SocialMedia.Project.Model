using Microsoft.EntityFrameworkCore;
using Social.Media.Project.Models.Abstract;
using SocialMedia.Project.DAL.Context;
using SocialMedia.Project.DAL.IRepositories.Abstract;

namespace SocialMedia.Project.DAL.IRepositories.Concrate;

public class BaseRepository<T> : IRepository<T> where T :BaseEntity, new()
{
    private readonly SocialMediaDbContext _context;
    private readonly DbSet<T> _dbSet;
    private SocialMediaDbContext context;

    public BaseRepository()
    {
        _context = new SocialMediaDbContext();
        _dbSet = _context.Set<T>();
    }

    public BaseRepository(SocialMediaDbContext context)
    {
        this.context = context;
    }

    public void Add(T entity)
    {
        _context.Add(entity);
    }

    public void Delete(int id)
    {
        var delEntity = _dbSet.FirstOrDefault(de => de.Id == id);
        if (delEntity!=null)
        {
            delEntity.IsDeleted = true;
            delEntity.DeletedDate = DateTime.Now;
        }
        else
        {
            throw new DllNotFoundException();
        }
    }

    public ICollection<T> GetAll()
    {
       return _dbSet.Where(t=>t.IsDeleted == true).ToList();
    }

    public T GetById(int id)
    {
        var entity = _dbSet.Where(e=>e.IsDeleted==true).FirstOrDefault(_ => _.Id == id);
        if (entity != null)
        {
            return entity;
        }
        else
        {
            throw new NullReferenceException();
        }
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

