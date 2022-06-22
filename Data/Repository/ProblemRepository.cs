namespace ToDoList21.Data.Repository
{
    public class ProblemRepository
    {
        private readonly AppDBContext _appDBContext;

        public ProblemRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
    }
}
