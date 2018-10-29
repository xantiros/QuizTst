using QuizTst.Core.Database;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizTst
{
    public partial class Form1 : Form
    {
        public SQLiteDatabase db = new SQLiteDatabase();

        List<Question> questions = new List<Question>();

        public Form1()
        {
            InitializeComponent();

            db.ConnectToDatabase();

            questions = db.GetAllQuestions("Questions");
        }
    }
}
