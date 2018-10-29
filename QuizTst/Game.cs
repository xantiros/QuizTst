using QuizTst.Core.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Game : Form
    {
        public SQLiteDatabase db = new SQLiteDatabase();

        //List<Question> questions = new List<Question>();

        private bool button1WasClicked = false;

        int idQuest = 1;

        Question que;

        public Game()
        {
            InitializeComponent();

            ShowQuestion(idQuest);

            void ShowQuestion(int id)
            {
                que = db.GetQuestion("Questions", idQuest);
                Content.Text = que.Content + " nr: " + idQuest;
                rbAA.Text = que.A;
                rbBB.Text = que.B;
                rbCC.Text = que.C;
                rbDD.Text = que.D;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var answer += rbAA.Checked;
            if (rbAA.Checked == que.Correct)

            idQuest++;
        }
    }
}
