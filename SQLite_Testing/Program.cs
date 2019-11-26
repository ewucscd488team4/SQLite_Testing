using System;
using System.Data.SQLite;

namespace SQLite_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            const string testDatabase = @"C:\Users\Diesel\Documents\Sausa\MyDatabase.sqlite";

            SQLiteConnection.CreateFile("MyDatabase.sqlite"); //creates file if it does not exist, overwrites it if it does.

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;"); //database connection parameters
            m_dbConnection.Open(); //opens database connection, should be surrounded by try catch block

            string sql = "create table highscores (name varchar(20), score int)"; //sql command to execute

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection); //sets up sql command to execute

            command.ExecuteNonQuery(); //execute sql command

            sql = "insert into highscores (name, score) values ('Me', 9001)"; //new sql command to execute

            command = new SQLiteCommand(sql, m_dbConnection); //again sets up sql command to execute

            command.ExecuteNonQuery(); //ececutes new sql command

            m_dbConnection.Close(); //closes sql database connection
        }
    }
}
