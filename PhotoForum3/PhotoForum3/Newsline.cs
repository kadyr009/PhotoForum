using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using System.Security.Cryptography;

namespace PhotoForum
{
    public partial class Newsline : Form
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public Newsline()
        {
            InitializeComponent();
        }

        private void Newsline_Load(object sender, EventArgs e)
        {
            Program.newsline = this;

            Update_Newsline();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPhoto addingForm = new AddPhoto();
            addingForm.ShowDialog();
        }

        private int LikesCount(string photoID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) { 
                string likesCountQuery = "SELECT * FROM Likes WHERE PhotoID = @PhotoID";
                SQLiteCommand likesCountCommand = new SQLiteCommand(likesCountQuery, connection);
                likesCountCommand.Parameters.AddWithValue("@PhotoID", photoID);
                connection.Open();
                SQLiteDataReader likesCountReader = likesCountCommand.ExecuteReader();

                int likesCount = 0;

                while (likesCountReader.Read())
                {
                    likesCount++;
                }

                return likesCount;  
            }
        }

        public void CreatePanel(PhotoControl formsControl)
        {
            NewslineLayoutPanel.Controls.Add(formsControl);
        }

        public void Update_Newsline()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Photos";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PhotoControl photoControl = new PhotoControl();
                    photoControl.PhotoPath = reader["ImagePath"].ToString();
                    photoControl.LikesCount = LikesCount(reader["PhotoID"].ToString());
                    photoControl.Description = reader["Description"].ToString();
                    photoControl.Width = 372;
                    photoControl.Height = 320;

                    NewslineLayoutPanel.Controls.Add(photoControl);
                }
            }
        }
    }
}
