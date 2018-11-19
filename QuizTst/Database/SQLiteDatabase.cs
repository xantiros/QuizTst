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

        //https://drive.google.com/file/d/1ROXmQQ98IGlwmgnc4zsGgGKpJlKAeC5h/view?usp=sharing -my file
        //https://drive.google.com/uc?export=download&id=ABCDEFG1234567 --przyklad
        //https://drive.google.com/uc?export=download&id=1ROXmQQ98IGlwmgnc4zsGgGKpJlKAeC5h
        public List<Question> GetAllQuestions(string questions)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=./Database/QuizDB.db"))
            {
                var Quest = SQLiteConnection.Query<Question>($"select * from {questions}", new DynamicParameters());
                return Quest.ToList();
            }
        }
        public Question GetQuestion(string question, int id)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=./Database/QuizDB.db"))
            {
                return SQLiteConnection.QuerySingleOrDefault<Question>($"select * from {question} where Id = {id}", new DynamicParameters());
            }
        }
        public void SaveToDatabase(Question question)
        {
            //not necessery
            //SQLiteConnection.Execute($"insert into {question.GetType().Name} () values ()", question);
        }
    }
}
