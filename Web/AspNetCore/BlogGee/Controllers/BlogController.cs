using Microsoft.AspNetCore.Mvc;
using BlogGee.Models;
using System.Linq;

namespace BlogGee.Controllers
{
    
    public class BlogController : Controller
    {
        BlogGeeContext db;

        public BlogController(BlogGeeContext context)
        {
            db = context;
        } 

        public IActionResult Index()
        {
            return View(db.Posts.ToList());
        }
    }
}