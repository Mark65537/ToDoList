using System.Collections.Generic;
using System.Linq;

namespace ToDoList21.Models
{
    public class ProblemListingViewModel
    {
        public string Title { get; set; }

        public int? ProblemId { get; set; }

        public virtual List<ProblemListingViewModel> SubProblems { get; set; }

        public ProblemListingViewModel()
        {
        }
        public ProblemListingViewModel(Problem model)
        {
            Title = model.Title;

            if (model.ProblemId != null)
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
