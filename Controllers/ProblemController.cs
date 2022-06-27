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

        public ViewResult Delete(int id)
        {
            var model = _appDBContext.ProblemSet.First(x => x.Id == id);
            return View(new ProblemDeleteViewModel(model));
        }
        [HttpPost]
        public ActionResult Delete([Bind("id, Title")]  ProblemDeleteViewModel model)
        {
            if (ModelState.IsValid) {
                var rprob = new Problem
                {
                    Id = model.id
                };

                _appDBContext.Remove(rprob);
                _appDBContext.SaveChanges();

                TempData["Message"] = "Задача " + rprob.Title + " успешно удалена!";

                return RedirectToAction("Index");
            }
            TempData["Message"] = "Задача " + model.Title + " не может быть удалена!";

            return RedirectToAction("Index");
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
        public ActionResult GetDescription(string id)//важно что бы имя совпадало
        {

            if (!string.IsNullOrEmpty(id))
            {
                var model = _appDBContext.ProblemSet.First(x => x.Id == int.Parse(id));
                if (model != null)
                {
                    return PartialView("_DisplayProblemDescriptionPartial", new ProblemDescriptionViewModel(model));//модель должна совпадать
                }
            }
            throw new NullReferenceException();
        }
        public ViewResult AddSubTask(int id)
        {
            //var model = _appDBContext.ProblemSet.First(x => x.Id == int.Parse(id));

            //ViewData["TerminalId"] = model.Id;
            //ViewData["TerminalTitle"] = model.Title;

            return View(new ProblemCreateViewModel());
        }
    }
}
