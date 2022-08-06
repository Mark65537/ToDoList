using System.ComponentModel.DataAnnotations;

namespace ToDoList21.Models
{
    public class ProblemCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [StringLength(126, MinimumLength = 3,
            ErrorMessage = "Название должно содержать не менее 3 и не более 126 символов")]
        [Display(Name = "Title")]
        public string Title{ get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Executors")]
        public string Executors { get; set; }

        [Display(Name = "PlannedComplexityTime")]
        [Range(0,int.MaxValue)]
        public int PlannedComplexityTime { get; set; }
        public int ProblemId { get; set; }
        public ProblemCreateViewModel()
        {
        }
        public ProblemCreateViewModel(int ProblemId)
        {
            this.ProblemId= ProblemId;
        }
        public ProblemCreateViewModel(Problem model)
        {
        }
    }
}
