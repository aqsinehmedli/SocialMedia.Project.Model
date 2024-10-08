using Social.Media.Project.Models.Abstract;

namespace SocialMedia.Project.DAL.IRepositories.Abstract;

public interface IRepository<T> where T : BaseEntity, new()
{
    public void Add(T entity);
    public void Delete(int id);
    public T GetById(int id);
    public ICollection<T> GetAll();
    public void SaveChanges();

}

