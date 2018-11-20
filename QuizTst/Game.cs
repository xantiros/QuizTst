using QuizTst.Core.Database;
using QuizTst.Core.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Game : Form
    {
        SQLiteDatabase db = new SQLiteDatabase();

        Player player = new Player(0, 0, 0, 0);
        int question_id = 1;
        Question que;

        public Game()
        {
            InitializeComponent();

            que = Helper.GetQuestion(db, question_id);
            Helper.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
            progressBar1.Maximum = db.CountQuestions("Questions");
            progressBar1.Step = 1;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (que is null)
                return;
            Helper.CheckAnswer(player, que, content, rbAA, rbBB, rbCC, rbDD);
            que = Helper.GetQuestion(db, question_id);
            if (que is null)
            {
                Helper.EndQuiz(player);
                return;
            }
            question_id++;
            Helper.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
            progressBar1.PerformStep();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            panel_1_100.Visible = false;
            panel_Game.Visible = true;
        }
    }
}
