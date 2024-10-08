using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Project.Models.Concrate;

namespace SocialMedia.Project.DAL.Configurations;
public class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
{
    public void Configure(EntityTypeBuilder<UserDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Surname).IsRequired();

        builder.Property(ud => ud.UserId)
            .IsRequired();

    }
}
