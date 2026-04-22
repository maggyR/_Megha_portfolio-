using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "E-Commerce App",
                    Description = "Online shopping platform",
                    TechStack = ".NET, SQL",
                    GitHubLink = "https://github.com/yourrepo"
                },
                new Project
                 {
                    Title = "Task Manager",
                    Description = "Manage daily tasks",
                    TechStack = "ASP.NET Core",
                    GitHubLink = "https://github.com/yourrepo"
                },
                new Project
                {
                    Title = "E-Commerce App",
                    Description = "Online shopping platform",
                    TechStack = ".NET, SQL",
                    GitHubLink = "https://github.com/yourrepo"
                },
                new Project
                 {
                    Title = "Task Manager",
                    Description = "Manage daily tasks",
                    TechStack = "ASP.NET Core",
                    GitHubLink = "https://github.com/yourrepo"
                },
                new Project
                {
                    Title = "E-Commerce App",
                    Description = "Online shopping platform",
                    TechStack = ".NET, SQL",
                    GitHubLink = "https://github.com/yourrepo"
                },
                new Project
                 {
                    Title = "Task Manager",
                    Description = "Manage daily tasks",
                    TechStack = "ASP.NET Core",
                    GitHubLink = "https://github.com/yourrepo"
                }
           };
            return View(projects);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
