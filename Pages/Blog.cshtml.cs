using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogApp.Services;
using BlogApp.Models;

namespace BlogApp.Pages
{
    public class BlogModel : PageModel
    {
        private readonly BlogService _blogService;

        public BlogModel(BlogService blogService)
        {
            _blogService = blogService;
        }

        public List<BlogPost> Posts { get; set; } = new List<BlogPost>();

        public void OnGet()
        {
            Posts = _blogService.GetAllPosts();
        }
    }
} 