using System.ComponentModel.DataAnnotations;

namespace ToDoList21.Models
{
    public class ProblemDeleteViewModel
    {
        [Display(Name = "id")]
        public int? id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        //[Display(Name = "Description")]
        //public string Description { get; set; }
        public ProblemDeleteViewModel()//обязательно должен быть
        {
        }
        public ProblemDeleteViewModel(Problem model)
        {
            id = model.Id;
            Title = model.Title;
            //Description = model.Description;
        }
    }
}
