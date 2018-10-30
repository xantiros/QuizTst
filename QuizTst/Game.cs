using QuizTst.Core.Database;
using QuizTst.Core.Models;
using System;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Game : Form
    {
        public SQLiteDatabase db = new SQLiteDatabase();

        //List<Question> questions = new List<Question>();

        Player player = new Player(1, 0);
        Question que;

        public Game()
        {
            InitializeComponent();

            ShowQuestion(player.QuestionId);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (rbAA.Checked == true && 1 == que.Correct)
            {
                player.AddPoint();
                player.NextQuestionId();
            }
            else if (rbBB.Checked == true && 2 == que.Correct)
            {
                player.AddPoint();
                player.NextQuestionId();
            }
            else if (rbCC.Checked == true && 3 == que.Correct)
            {
                player.AddPoint();
                player.NextQuestionId();
            }
            else if (rbDD.Checked == true && 4 == que.Correct)
            {
                player.AddPoint();
                player.NextQuestionId();
            }
            else if (rbAA.Checked == false && rbBB.Checked == false 
                && rbCC.Checked == false && rbDD.Checked == false)
            {
                string message = "Mark the answere";
                string caption = "Error";
                MessageBoxButtons button = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, caption);                 //result = MessageBox.Show(message, caption, button);
            }
            else
            {
                string message = "Wrong answeer. The correct answer was: " + que.Correct;
                string caption = "Wrong answeer.";
                MessageBoxButtons button = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, caption);
                player.NextQuestionId();
            }
            ShowQuestion(player.QuestionId);
        }

        public void ShowQuestion(int id)
        {
            que = db.GetQuestion("Questions", id);
            Content.Text = que.Content + " nr: " + id;
            rbAA.Text = que.A;
            rbBB.Text = que.B;
            rbCC.Text = que.C;
            rbDD.Text = que.D;
        }
    }
}
