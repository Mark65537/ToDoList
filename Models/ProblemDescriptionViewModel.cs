using System;

namespace ToDoList21.Models
{
    public class ProblemDescriptionViewModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public int ProblemId { get; set; }

        public ProblemDescriptionViewModel(Problem model)
        {
            Id = model.Id;
            Title = model.Title;
            Description = model.Description;
            StartDate = model.StartDate;
            FinishDate = model.FinishDate;
        }
    }
}
