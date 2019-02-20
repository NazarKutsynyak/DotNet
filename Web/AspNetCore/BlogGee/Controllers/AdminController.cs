using Microsoft.AspNetCore.Mvc;
using BlogGee.Models;
using System.Linq;

namespace BlogGee.Controllers
{
    
    public class AdminController : Controller
    {
        BlogGeeContext db;

        public AdminController(BlogGeeContext context)
        {
            db = context;
        } 

        public IActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public ViewResult Update (int id)
        {
            Post post = db.Posts.FirstOrDefault(g => g.ID == id);
            return View(post);
        }
    }
}