using QuizTst.Core.Database;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Form1 : Form
    {
        public SQLiteDatabase db = new SQLiteDatabase();

        public Form1()
        {
            InitializeComponent();
            panel_Levels.Visible = false;
        }

        private void btn_Play_Click(object sender, System.EventArgs e)
        {
            panel_StarWindow.Visible = false;
            panel_Levels.Visible = true;
        }

        private void btn_CheckForUpdates_Click(object sender, System.EventArgs e)
        {
            db.DownloadDatabase();
        }

        private void btn_Level1_Click(object sender, System.EventArgs e)
        {
            Hide();
            var game = new Game();
            game.Closed += (s, args) => Show();           //game.Closed += (s, args) => Close();
            game.Show();
        }
    }
}
