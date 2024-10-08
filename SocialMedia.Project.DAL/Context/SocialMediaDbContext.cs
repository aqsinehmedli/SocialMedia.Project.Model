using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Social.Media.Project.Models.Concrate;
using SocialMedia.Project.DAL.Configurations;
using SocialMedia.Project.Models.Concrate;

namespace SocialMedia.Project.DAL.Context;

//using Microsoft.Extensions.Options;


public class SocialMediaDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-0MV3INK;Initial Catalog = SocialMediaDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");  
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserDetailConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}




