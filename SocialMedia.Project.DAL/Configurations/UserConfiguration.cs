using Microsoft.EntityFrameworkCore;
using Social.Media.Project.Models.Concrate;
using SocialMedia.Project.Models.Concrate;

namespace SocialMedia.Project.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder
            .HasMany(u => u.Post)
            .WithOne(p => p.User)
            .HasForeignKey(u => u.UserId);


        builder
           .HasOne(u => u.UserDetail)
           .WithOne(ud => ud.User)
           .HasForeignKey<UserDetail>(ud => ud.UserId);
    }
}
