using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Models;
using System.Diagnostics;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("HomePage");
        }

        public ViewResult NewPost()
        {
            return View();
        }
    }
}