using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList21.Models
{
    public class ProblemUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Необходимо ввести название")]
        [StringLength(126, MinimumLength = 3,
            ErrorMessage = "Название должно содержать не менее 3 и не более 126 символов")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Executors")]
        public string Executors { get; set; }

        [Display(Name = "Status")]
        public ProblemStatus Status { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}",
            ApplyFormatInEditMode = true)]
        [Display(Name = "FinishDate")]
        public DateTime? FinishDate { get; set; }

        [Display(Name = "FactTime")]
        public int? FactTime { get; set; }
        public ProblemUpdateViewModel()
        {
        }
        public ProblemUpdateViewModel(Problem model)
        {
            Title = model.Title;
            Description = model.Description;
            Executors = model.Executors;
            Status = model.Status;
            FinishDate = model.FinishDate;
            FactTime = model.FactTime;
        }
    }
}
