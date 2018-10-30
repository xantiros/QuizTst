namespace QuizTst
{
    public class Question
    {
        public int Id { get; private set; }
        public string Content { get; private set; }
        public string A { get; private set; }
        public string B { get; private set; }
        public string C { get; private set; }
        public string D { get; private set; }
        public int Correct { get; private set; }

        public Question(int id, string content, string a, string b, string c, string d, int correct)
        {
            Id = id;
            Content = content;
            A = a;
            B = b;
            C = c;
            D = d;
            Correct = correct;
        }

        protected Question()
        {
        }
    }
}
