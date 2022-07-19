using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Models;
using System.Diagnostics;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("HomePage", PostRepository.Posts.Where(p => p.AuthorName != null));
        }

        public ViewResult NewPost(PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                PostRepository.AddNewPost(postModel);
                return View("Success", postModel);
            }
            else
            {
                // Обнаружена ошибка проверки достоверности
                return View();
            }
        }

        public ViewResult Success()
        {
            return View();
        }
    }
}