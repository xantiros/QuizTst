using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Configuration;

namespace QuizTst.Core.Database
{
    public class SQLiteDatabase
    {
        public IDbConnection SQLiteConnection { get; private set; }

        public void ConnectToDatabase()
        {
            //using (IDbConnection con = new SQLiteConnection("Data Source=UtilitiesDB.db"))
            //{
            //}
            SQLiteConnection = new SQLiteConnection(LoadConnectionString());
            //SQLiteConnection.Open();
        }
        public List<Question> GetUtilities(string question)
        {
            var Quest = SQLiteConnection.Query<Question>($"select * from {question}", new DynamicParameters());
            return Quest.ToList();
        }
        public void SaveToDatabase(Question utility)
        {
            SQLiteConnection.Execute($"insert into {utility.GetType().Name} (date, value, amount, unitprice, totalprice) values (@date, @value, @amount, @unitprice, @totalprice)", utility);
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
