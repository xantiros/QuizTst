namespace QuizTst.Core.Models
{
    public class AnsweredQuestions
    {
        public int Id { get; private set; }
        public int Level { get; private set; }

        public AnsweredQuestions(int id, int level)
        {
            Id = id;
            Level = level;
        }
        protected AnsweredQuestions()
        {
        }
    }
}
