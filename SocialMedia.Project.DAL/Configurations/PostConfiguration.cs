using Microsoft.EntityFrameworkCore;
using Social.Media.Project.Models.Concrate;
using Microsoft.EntityFrameworkCore;

namespace SocialMedia.Project.DAL.Configurations;



public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.LikeCount);
        builder.Property(p => p.Text);

        builder
            .HasMany(p => p.PostComments)
            .WithOne(cp => cp.Post)
            .HasForeignKey(cp => cp.PostId);

    }
}


