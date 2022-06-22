using Microsoft.AspNetCore.Mvc;
using ToDoList21.Models;

namespace ToDoList21.Controllers
{
    public class ProblemController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View(new ProblemCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(
            [Bind("Title, Description, Executors, " +
                    "PlannedComplexityTime")]
                           ProblemCreateViewModel model
            )
        {
            if (ModelState.IsValid)
            {
                var newProblem = new Problem
                {
                    Title = model.Title,
                    Description = model.Description,
                    Executors = model.Executors,
                    PlannedComplexityTime = model.PlannedComplexityTime
                };

                TempData["Message"] = "Задача " + newProblem.Title + " успешно создана!";

                return RedirectToAction("Index");
            }

            TempData["Message"] = "Задача " + model.Title + " не может быть создана!";

            return View(model);
        }
    }
}
