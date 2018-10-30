namespace QuizTst.Core.Models
{
    public class Player
    {
        public int QuestionId { get; private set; }
        public int Points { get; private set; }

        public Player(int questionId, int points)
        {
            QuestionId = questionId;
            Points = points;
        }
        public void AddPoint()
        {
            Points++;
        }
        public void NextQuestionId()
        {
            QuestionId++;
        }

        protected Player()
        {
        }
    }
}
