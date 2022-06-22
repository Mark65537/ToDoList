using System;
using System.Collections.Generic;

namespace ToDoList21.Models
{
    public class Problem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Executors { get; set; }
        public DateTime StartDate { get; set; }
        public ProblemStatus Status { get; set; }
        public int PlannedComplexityTime { get; set; }
        public int? FactTime { get; set; }
        public DateTime? FinishDate { get; set; }
        public virtual ICollection<Problem> SubProblems { get; set; }
    }
}
