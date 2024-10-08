namespace SocialMedia.Project.DAL.Configurations;

using Microsoft.EntityFrameworkCore;
using Social.Media.Project.Models.Concrate;
using System.Xml.Linq;


public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Comments);
        builder.Property(c => c.LikeCount);

        builder
            .HasMany(c => c.PostComments)
            .WithOne(cp => cp.Comment)
            .HasForeignKey(cp => cp.CommentId);
    }
}
