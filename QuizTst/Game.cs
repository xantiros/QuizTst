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

        public Form1 form1;
        //Player player = new Player(0, 0, 0, 0);
        int question_id = 1;
        Question que;

        public Game()
        {
            InitializeComponent();

            que = Helper.GetQuestion(db, question_id);
            Helper.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
            question_id++;
            progressBar1.Maximum = db.CountQuestions("Questions");
            progressBar1.Step = 1;
            progressBar1.PerformStep();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (que is null)
                return;
            Helper.CheckAnswer(Playeer.player, que, content, rbAA, rbBB, rbCC, rbDD);
            que = Helper.GetQuestion(db, question_id);
            if (que is null)
            {
                db.UpdatePlayer(Playeer.player);
                Helper.EndQuiz(Playeer.player);
                return;
            }
            question_id++;
            Helper.ShowQuestion(que, content, rbAA, rbBB, rbCC, rbDD);
            progressBar1.PerformStep();
        }
    }
}
