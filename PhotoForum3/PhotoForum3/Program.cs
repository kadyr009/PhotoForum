using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoForum
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static int userID;
        public static Newsline newsline;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CreateDatabase();

            Application.Run(new MainForm());
        }

        private static void CreateDatabase()
        {
            string dbPath = "Data Source=PhotoForumDB.sqlite;";
            using (SQLiteConnection connection = new SQLiteConnection(dbPath))
            {
                connection.Open();

                if (!TableExists(connection, "Users")) 
                {
                    string createTableQuery = @"CREATE TABLE Users (
                                    UserID INT IDENTITY(1,1) PRIMARY KEY,
                                    Username NVARCHAR(50) UNIQUE NOT NULL,
                                    Password NVARCHAR(255) NOT NULL,
                                    Email NVARCHAR(100) UNIQUE NOT NULL,
                                    Role NVARCHAR(50) NOT NULL
                                    );";
                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                }
                if (!TableExists(connection, "Photos"))
                {
                    string createTableQuery = @"CREATE TABLE Photos (
                                    PhotoID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    UserID INTEGER NOT NULL,
                                    Title NVARCHAR(100) NOT NULL,
                                    Description NVARCHAR(255),
                                    DateUploaded DATETIME DEFAULT CURRENT_TIMESTAMP,
                                    ImagePath NVARCHAR(255) NOT NULL,
                                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                                    );";
                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                }
                if (!TableExists(connection, "Comments"))
                {
                    string createTableQuery = @"CREATE TABLE Comments (
                                    CommentID INTEGER IDENTITY(1,1) PRIMARY KEY,
                                    PhotoID INTEGER NOT NULL,
                                    UserID INTEGER NOT NULL,
                                    CommentText NVARCHAR(255) NOT NULL,
                                    DatePosted DATETIME DEFAULT CURRENT_TIMESTAMP,
                                    FOREIGN KEY (PhotoID) REFERENCES Photos(PhotoID),
                                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                                    );";
                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                }
                if (!TableExists(connection, "Likes"))
                {
                    string createTableQuery = @"CREATE TABLE Likes (
                                    LikeID INT IDENTITY(1,1) PRIMARY KEY,
                                    PhotoID INT NOT NULL,
                                    UserID INT NOT NULL,
                                    DateLiked DATETIME DEFAULT CURRENT_TIMESTAMP,
                                    FOREIGN KEY (PhotoID) REFERENCES Photos(PhotoID),
                                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                                    );";
                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        static bool TableExists(SQLiteConnection connection, string tableName)
        {
            string query = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';";
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}
