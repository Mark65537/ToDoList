using System.ComponentModel.DataAnnotations;

namespace ToDoList21.Models
{
    public class ProblemDeleteViewModel
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //public ProblemDeleteViewModel(Problem model)
        //{
        //    Title = model.Title;
        //    Description = model.Description;
        //}
    }
}
