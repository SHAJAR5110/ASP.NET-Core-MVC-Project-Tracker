using Microsoft.AspNetCore.Mvc;
using ProjectTrackerApp.Models;
using System.Collections.Generic;

namespace ProjectTrackerApp.Controllers
{
    public class ProjectsController : Controller
    {
        private static List<Project> projects = new List<Project>
        {
            new Project { Id = 1, Name = "AI Chatbot", Description = "Developing an AI-based chatbot", Status = "In Progress" },
            new Project { Id = 2, Name = "E-Commerce Website", Description = "Building a full-stack e-commerce site", Status = "Completed" },
            new Project { Id = 3, Name = "Mobile App", Description = "Developing a cross-platform mobile application", Status = "Pending" }
        };

        public IActionResult Index()
        {
            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var project = projects.Find(p => p.Id == id);
            if (project == null) return NotFound();
            return View(project);
        }

        [HttpPost]
        public IActionResult Add(Project newProject)
        {
            newProject.Id = projects.Count + 1;
            projects.Add(newProject);
            return RedirectToAction("Index");
        }
    }
}
