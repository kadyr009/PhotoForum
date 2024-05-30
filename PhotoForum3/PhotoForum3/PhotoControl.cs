using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoForum
{
    public partial class PhotoControl : UserControl
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public PhotoControl()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string PhotoPath
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        public int LikesCount
        {
            get { return Convert.ToInt32(lblLikesCount.Text); }
            set { lblLikesCount.Text = value.ToString(); }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public event EventHandler ShowCommentsClicked;

        private void ShowComments_Click(object sender, EventArgs e)
        {
            if (ShowCommentsClicked != null)
                ShowCommentsClicked(this, EventArgs.Empty);
        }

        private void LikeBut_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectPhotoIDQuery = "SELECT PhotoID FROM Photos WHERE ImagePath = @PhotoPath";
                SQLiteCommand SelectPhotoIDCommand = new SQLiteCommand(selectPhotoIDQuery, connection);
                SelectPhotoIDCommand.Parameters.AddWithValue("@PhotoPath", PhotoPath);
                connection.Open();
                SQLiteDataReader reader = SelectPhotoIDCommand.ExecuteReader();

                int photoId = int.Parse(reader["UserID"].ToString());

                string insertLikeQuery = "INSERT INTO Likes (PhotoID, UserID) VALUES (@PhotoID, @UserID)";
                SQLiteCommand command = new SQLiteCommand(insertLikeQuery, connection);
                SelectPhotoIDCommand.Parameters.AddWithValue("@UserID", Program.userID);
                SelectPhotoIDCommand.Parameters.AddWithValue("@PhotoID", photoId);
                SelectPhotoIDCommand.ExecuteNonQuery();

                Program.newsline.Update_Newsline();
            }
        }
    }
}

