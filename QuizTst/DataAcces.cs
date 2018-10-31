using QuizTst.Core.Database;
using QuizTst.Core.Models;
using System.Windows.Forms;

namespace QuizTst
{
    public static class Helper
    {
        public static void ShowQuestion(Question que, Label content, 
            RadioButton rbAA, RadioButton rbBB, RadioButton rbCC, RadioButton rbDD)
        {   
            content.Text = que.Content + " nr: " + que.Id;
            rbAA.Text = que.A;
            rbBB.Text = que.B;
            rbCC.Text = que.C;
            rbDD.Text = que.D;
        }
        public static Question GetQuestion(SQLiteDatabase db, Player player)
        {
            return db.GetQuestion("Questions", player.QuestionId);
        }
        public static void CheckAnswer(Player player, Question que, Label content, RadioButton rbAA, RadioButton rbBB, RadioButton rbCC, RadioButton rbDD)
        {
            if (rbAA.Checked == true && 1 == que.Correct)
            {
                player.AddPointPlusNextQuestionId();
            }
            else if (rbBB.Checked == true && 2 == que.Correct)
            {
                player.AddPointPlusNextQuestionId();
            }
            else if (rbCC.Checked == true && 3 == que.Correct)
            {
                player.AddPointPlusNextQuestionId();
            }
            else if (rbDD.Checked == true && 4 == que.Correct)
            {
                player.AddPointPlusNextQuestionId();
            }
            else if (rbAA.Checked == false && rbBB.Checked == false
                && rbCC.Checked == false && rbDD.Checked == false)
            {
                string message = "Mark the answere";
                string caption = "Error";
                //MessageBoxButtons button = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, caption);                 //result = MessageBox.Show(message, caption, button);
            }
            else
            {
                string message = "Wrong answeer. The correct answer was: " + que.Correct;
                string caption = "Wrong answeer.";
                //MessageBoxButtons button = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, caption);
                player.NextQuestionId();
            }
        }
        public static void EndQuiz(Player player)
        {
            string message = "Your points " + player.Points;
            string caption = "End Quiz";
            MessageBoxButtons button = MessageBoxButtons.OK;

            //DialogResult result = MessageBox.Show(message, caption);

            if (MessageBox.Show(message, caption, button) == DialogResult.OK)
            {
                Application.Restart();
            }

        }
    }
}
