using QuizTst.Core.Database;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Hide();
            var game = new Game();
            game.Closed += (s, args) => Show();           //game.Closed += (s, args) => Close();
            game.Show();

        }
    }
}
