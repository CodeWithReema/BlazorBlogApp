using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogApp.Services;
using BlogApp.Models;

namespace BlogApp.Pages
{
    public class CreatePostModel : PageModel
    {
        private readonly BlogService _blogService;

        public CreatePostModel(BlogService blogService)
        {
            _blogService = blogService;
        }

        [BindProperty]
        public BlogPost NewPost { get; set; } = new BlogPost();

        public void OnGet()
        {
            // Initialize the form
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (string.IsNullOrWhiteSpace(NewPost.Title) || string.IsNullOrWhiteSpace(NewPost.Content))
            {
                ModelState.AddModelError("", "Title and Content are required.");
                return Page();
            }

            _blogService.AddPost(NewPost);

            return RedirectToPage("/Blog");
        }
    }
} 