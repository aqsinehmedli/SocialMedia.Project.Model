using Social.Media.Project.Models.Concrate;
using SocialMedia.Project.DAL.IRepositories.Concrate;
using SocialMedia.Project.Model.Enum;
using SocialMedia.Project.Models.Concrate;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        BaseRepository<User> baseRepository = new();
        BaseRepository<UserDetail> baseRepository1 = new();
        BaseRepository<Post> baseRepository2 = new();
        BaseRepository<Comment> baseRepository3 = new();

        var userDetail1 = new UserDetail
        {
            Name = "Elçin",
            Surname = "Əliyev",
            Birthday = new DateTime(1990, 5, 20),
            Role = Enums.User
        };

        var userDetail2 = new UserDetail
        {
            Name = "Nigar",
            Surname = "Hüseynova",
            Birthday = new DateTime(1985, 3, 15),
            Role = Enums.Admin
        };

        // İstifadəçilər
        var user1 = new User
        {
            UserDetail = userDetail1,
            Post = new List<Post>(),
        };

        var user2 = new User
        {
            UserDetail = userDetail2,
            Post = new List<Post>(),
        };

        // Göndərişlər
        var post1 = new Post
        {
            Text = "Bu bir nümunə göndərişdir.",
            LikeCount = 10,
            UserId = user1.Id,
            User = user1,
        };

        var post2 = new Post
        {
            Text = "Başqa bir göndəriş.",
            LikeCount = 5,
            UserId = user2.Id,
            User = user2,
        };

        // Şərhlər
        var comment1 = new Comment
        {
            Comments = "Möhtəşəm bir göndəriş!",
            LikeCount = 3,
        };

        var comment2 = new Comment
        {
            Comments = "Təşəkkürlər!",
            LikeCount = 2,
        };
        //baseRepository.Add(user1);
        //baseRepository.Add(user2);

        //baseRepository1.Add(userDetail1);
        //baseRepository1.Add(userDetail2);

        //baseRepository2.Add(post1);
        //baseRepository2.Add(post2);

        //baseRepository3.Add(comment1);
        //baseRepository3.Add(comment2);

        //baseRepository2.Delete(4);

        var product = baseRepository2.GetAll().ToList();
        foreach (var item in product)
        {
            Console.WriteLine(item);
        }

        baseRepository2.SaveChanges();
        //baseRepository2.SaveChanges();
        //baseRepository2.SaveChanges();
        //baseRepository3.SaveChanges();

    }
}