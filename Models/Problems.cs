using System;
using System.Collections.Generic;

namespace ToDoList21.Models
{
    public class Problems
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExecutorsList { get; set; }
        public DateTime StartDate { get; set; }
        public ProblemStatus Status { get; set; }
        public int PlannedComplexityTime { get; set; }
        public int? FactTime { get; set; }
        public DateTime? FinishDate { get; set; }
        public virtual ICollection<Problems> SubProblems { get; set; }
    }
}
