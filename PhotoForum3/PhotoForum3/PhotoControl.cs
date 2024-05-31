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
        private int photoId = -1;

        public PhotoControl()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int PhotoID
        {
            get { return photoId; }
            set { photoId = value; }
        }

        public string PhotoPath
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
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
        private void PhotoControl_Load(object sender, EventArgs e)
        {
            lblLikesCount.Text = CountLikes().ToString();
        }
        private void LikeBut_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertLikeQuery = "INSERT INTO Likes (PhotoID, UserID) VALUES (@PhotoID, @UserID)";
                using (SQLiteCommand insertLikeCommand = new SQLiteCommand(insertLikeQuery, connection))
                {
                    insertLikeCommand.Parameters.AddWithValue("@UserID", Program.UserID);
                    insertLikeCommand.Parameters.AddWithValue("@PhotoID", photoId);
                }
            }
        }

        private int CountLikes()
        {
            int likeCount = 0;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string countLikesQuery = "SELECT COUNT(*) FROM Likes WHERE PhotoID = @PhotoID";
                using (SQLiteCommand countLikesCommand = new SQLiteCommand(countLikesQuery, connection))
                {
                    countLikesCommand.Parameters.AddWithValue("@PhotoID", photoId);

                    connection.Open();

                    likeCount = Convert.ToInt32(countLikesCommand.ExecuteScalar());
                }
            }

            return likeCount;
        }
    }
}

