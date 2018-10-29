using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace QuizTst.Core.Database
{
    public class SQLiteDatabase
    {
        public IDbConnection SQLiteConnection { get; private set; }

        public void ConnectToDatabase()
        {
            //using (IDbConnection con = new SQLiteConnection("Data Source=QuizDb.db"))
            //{
            //}
            //SQLiteConnection = new SQLiteConnection(LoadConnectionString());
            //SQLiteConnection.Open();
        }
        public List<Question> GetAllQuestions(string questions)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=./Database/QuizDB.db"))
            {
                var Quest = SQLiteConnection.Query<Question>($"select * from {questions}", new DynamicParameters());
                return Quest.ToList();
            }
        }
        public void SaveToDatabase(Question question)
        {
            //not necessery
            //SQLiteConnection.Execute($"insert into {question.GetType().Name} () values ()", question);
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return null;//ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
