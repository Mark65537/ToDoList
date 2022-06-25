using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList21.Data;
using ToDoList21.Models;
using System.Linq;

namespace ToDoList21.Controllers
{
    public class ProblemController: Controller
    {
        private readonly AppDBContext _appDBContext=new AppDBContext();
        public IActionResult Index()
        {
            var model=_appDBContext.ProblemSet.ToList();
            return View(model);
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
                    PlannedComplexityTime = model.PlannedComplexityTime,
                    StartDate = DateTime.Now
                };

                TempData["Message"] = "Задача " + newProblem.Title + " успешно создана!";

                _appDBContext.Add(newProblem);
                _appDBContext.SaveChanges();

                return RedirectToAction("Index");
            }

            TempData["Message"] = "Задача " + model.Title + " не может быть создана!";

            return View(model);
        }

        public ViewResult Update(int id)
        {
            //var Problems ;

            //if (Problems != null)
            //{
            //    return View(new ProblemUpdateViewModel(Problems));
            //}

            throw new NullReferenceException(message: "Задача не может быть изменена, так как не была найдена в БД");
        }

        public PartialViewResult GetDescription(string jsonInput)
        {
            //var model = new ProblemDescriptionViewModel(int.Parse(jsonInput));

            //if (model != null)
            //{
            //    return PartialView("_DisplayTaskDescriptionPartial", model);
            //}
            //else
            throw new NullReferenceException();
        }
    }
}
