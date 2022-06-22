using System.Collections.Generic;
using System.Linq;

namespace ToDoList21.Models
{
    public class ProblemListingViewModel
    {
        public string Title { get; set; }

        public virtual List<ProblemListingViewModel> SubProblems { get; set; }


        public ProblemListingViewModel(Problem model)
        {
            Title = model.Title;

            if (model.SubProblems != null && model.SubProblems.Any())
            {
                SubProblems = model.SubProblems.Select(s => new ProblemListingViewModel(s)).ToList();
            }
            else
            {
                SubProblems = new List<ProblemListingViewModel>();
            }
        }
    }
}
