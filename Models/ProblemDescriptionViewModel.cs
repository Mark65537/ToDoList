namespace ToDoList21.Models
{
    public class ProblemDescriptionViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public ProblemDescriptionViewModel(Problem model)
        {
            Id = model.Id;
            Description = model.Description;
        }
    }
}
