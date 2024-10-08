using Social.Media.Project.Models.Abstract;
using Social.Media.Project.Models.Concrate;
using SocialMedia.Project.Model.Enum;
using System;

namespace SocialMedia.Project.Models.Concrate;

public class UserDetail : BaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime Birthday { get; set; }
    public Enums Role { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
