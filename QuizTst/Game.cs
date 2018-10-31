using QuizTst.Core.Database;
using QuizTst.Core.Models;
using System;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Game : Form
    {
        public SQLiteDatabase db = new SQLiteDatabase();

        Player player = new Player(1, 0);
        Question que;

        public Game()
        {
            InitializeComponent();

            que = DataAcces.GetQuestion(db, player);
            DataAcces.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (que is null)
                return;
            DataAcces.CheckAnswer(player, que, content, rbAA, rbBB, rbCC, rbDD);
            que = DataAcces.GetQuestion(db, player);
            if (que is null)
            {
                EndQuiz(player);
                return;
            }
            DataAcces.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
        }
    }
}
