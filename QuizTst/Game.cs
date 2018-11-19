using QuizTst.Core.Database;
using QuizTst.Core.Models;
using System;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Game : Form
    {
        SQLiteDatabase db = new SQLiteDatabase();

        Player player = new Player(1, 0);
        Question que;

        public Game()
        {
            InitializeComponent();

            que = Helper.GetQuestion(db, player);
            Helper.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
            progressBar1.Maximum = db.CountQuestions("Questions");
            progressBar1.Step = 1;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (que is null)
                return;
            Helper.CheckAnswer(player, que, content, rbAA, rbBB, rbCC, rbDD);
            que = Helper.GetQuestion(db, player);
            if (que is null)
            {
                Helper.EndQuiz(player);
                return;
            }
            Helper.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
            progressBar1.PerformStep();
        }
    }
}
