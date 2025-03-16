using Microsoft.AspNetCore.Mvc;
using ProjectTrackerApp.Models;

namespace ProjectTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        // Dummy project list (no database)
        private static List<Project> _projects = new List<Project>
        {
            new Project { Id = 1, Name = "Inventory Management System", Description = "A system to track products.", Status = "In Progress" },
            new Project { Id = 2, Name = "E-Commerce Website", Description = "An online shopping platform.", Status = "Completed" },
            new Project { Id = 3, Name = "Task Manager App", Description = "A productivity tool for teams.", Status = "Pending" }
        };

        public IActionResult Index()
        {
            return View(_projects);
        }

        // Simulate adding a new project
        public IActionResult AddProject()
        {
            int newId = _projects.Count + 1;
            _projects.Add(new Project
            {
                Id = newId,
                Name = $"New Project {newId}",
                Description = "A newly added dummy project.",
                Status = "In Progress"
            });

            return RedirectToAction("Index");
        }
    }
}
