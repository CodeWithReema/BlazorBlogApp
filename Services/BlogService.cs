using BlogApp.Models;

namespace BlogApp.Services
{
    public class BlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>();

        public BlogService()
        {
            // Add some sample posts for demonstration
            Posts.Add(new BlogPost
            {
                Title = "Welcome to My Blog",
                Content = "This is my first blog post. Welcome to my new blog!",
                CreatedAt = DateTime.Now.AddDays(-2)
            });

            Posts.Add(new BlogPost
            {
                Title = "Getting Started with ASP.NET Core",
                Content = "ASP.NET Core is a cross-platform framework for building web applications. It's fast, modern, and easy to use.",
                CreatedAt = DateTime.Now.AddDays(-1)
            });
        }

        public List<BlogPost> GetAllPosts()
        {
            return Posts.OrderByDescending(p => p.CreatedAt).ToList();
        }

        public void AddPost(BlogPost post)
        {
            post.CreatedAt = DateTime.Now;
            Posts.Add(post);
        }
    }
} 