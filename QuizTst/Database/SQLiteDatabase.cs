using Dapper;
using QuizTst.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;

namespace QuizTst.Core.Database
{
    public class SQLiteDatabase
    {
        //https://drive.google.com/file/d/1ROXmQQ98IGlwmgnc4zsGgGKpJlKAeC5h/view?usp=sharing -my file
        //https://stackoverflow.com/questions/35056500/download-file-from-google-drive-using-c-sharp-without-google-api
        //https://drive.google.com/uc?export=download&id=1ROXmQQ98IGlwmgnc4zsGgGKpJlKAeC5h

        WebClient wb = new WebClient();
        private readonly string DatabaseAdress = "https://drive.google.com/uc?export=download&id=1ROXmQQ98IGlwmgnc4zsGgGKpJlKAeC5h";

        public IDbConnection SQLiteConnection { get; private set; }

        public void DownloadDatabase()
        {
            //if (File.Exists("/QuizDB.db")) return;
            //else{
                try
                {
                    using (wb)
                    {
                        wb.DownloadFile(DatabaseAdress, "QuizDB.db");
                    }
                }
                catch (WebException)
                {
                    return;
                }    
        }

        public List<Question> GetAllQuestions(string questions)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=QuizDB.db"))
            {
                var Quest = SQLiteConnection.Query<Question>($"select * from {questions}", new DynamicParameters());
                return Quest.ToList();
            }
        }
        public Question GetQuestion(string question, int id)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=QuizDB.db"))
            {
                return SQLiteConnection.QuerySingleOrDefault<Question>($"select * from {question} where Id = {id}", new DynamicParameters());
            }
        }
        public int CountQuestions(string question)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=QuizDB.db"))
            {
                return SQLiteConnection.ExecuteScalar<int>($"select count(1) from {question}");
                    //SQLiteConnection.QuerySingleOrDefault<Question>($"select count(1) from {question}", new DynamicParameters());
            }
        }
        public void UpdatePlayer(Player player)
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=QuizDB.db"))
            {
                SQLiteConnection.Execute("update player set TotalPoints = @TotalPoints, Level1Points = @Level1Points, Level2Points = @Level2Points, Level3Points = @Level3Points", player);
            }
            //SQLiteConnection.Execute($"insert into {player} ({player.Total_Points, player.to})values ");
            //not necessery
            //SQLiteConnection.Execute($"insert into {question.GetType().Name} () values ()", question);
        }
        public Player GetPlayer()
        {
            using (SQLiteConnection = new SQLiteConnection("Data Source=QuizDB.db"))
            {
                return SQLiteConnection.QuerySingleOrDefault<Player>("select * from player", new DynamicParameters());
            }
        }
    }
}
