namespace Home_Away.DAL;
    public class ChoicesRepo:IChoicesRepo
    {

        private readonly UserContext _userContext;
        public ChoicesRepo(UserContext userContext)
        {
            _userContext = userContext;
        }
        public void AddChoices(Choices choice)
        {
            _userContext.Set<Choices>().Add(choice);
        }

        public void DeleteChoices(Choices choice)
        {
            _userContext.Set<Choices>().Remove(choice);
        }

        public Choices? GetChoicesById(int ChoiceId)
        {
            return _userContext.Set<Choices>().Find(ChoiceId);
        }

        public IEnumerable<Choices> GetChoicesByQuestionId(int questionId)
        {

            return _userContext.Set<Choices>().Where(c => c.QuestionsId == questionId).ToList();

        }

        public int SaveChanges()
        {
            return _userContext.SaveChanges();
        }

        public void UpdateChoices(Choices choice)
        {
            //
        }
    }
