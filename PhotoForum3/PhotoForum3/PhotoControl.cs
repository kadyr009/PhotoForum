using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhotoForum
{
    public partial class PhotoControl : System.Windows.Forms.UserControl
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";
        private int photoID = -1;

        bool isShow = false;

        public PhotoControl()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int PhotoID
        {
            get { return photoID; }
            set { photoID = value; }
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

        private void ShowComments_Click(object sender, EventArgs e)
        {
            if (!isShow)
            {
                panel2.Height = 200;
                this.Height += 200;

                CommentWrite commentWrite = new CommentWrite
                {
                    PhotoID = photoID,
                    Width = 372,
                    Height = 32
                };

                panel3.Controls.Add(commentWrite);
                panel3.Height = 35;

                int commentHeight = 0; 

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT c.CommentText, c.DatePosted, u.UserName FROM Comments c JOIN Users u ON c.UserID = u.UserID WHERE c.PhotoID = @PhotoID";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@PhotoID", photoID);
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentControl commentControl = new CommentControl
                            {
                                UserName = reader["UserName"].ToString(),
                                Comment = reader["CommentText"].ToString(),
                                Date = reader["DatePosted"].ToString(),
                                Width = 350,
                                Height = 100,
                                Top = commentHeight 
                            };

                            commentHeight += commentControl.Height; 

                            panel2.Controls.Add(commentControl);
                        }
                    }
                }

                panel2.Height = commentHeight > 200 ? commentHeight : 200;
                this.Height += panel2.Height - 200;

                isShow = true;
            }
            else
            {
                int originalPanel2Height = 200;
                int originalControlHeight = this.Height - panel2.Height + originalPanel2Height;

                panel2.Height = 0;

                foreach (System.Windows.Forms.Control control in panel2.Controls.OfType<CommentControl>().ToList())
                {
                    panel2.Controls.Remove(control);
                }

                this.Height = originalControlHeight - 200;

                isShow = false;
            }
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

                string isAlreadyLikedQuery = "SELECT * FROM Likes WHERE PhotoID = @PhotoID";
                using (SQLiteCommand isAlreadyLikedCommand = new SQLiteCommand(isAlreadyLikedQuery, connection))
                {
                    isAlreadyLikedCommand.Parameters.AddWithValue("@PhotoID", photoID);

                    using (SQLiteDataReader reader = isAlreadyLikedCommand.ExecuteReader())
                    {
                        bool isAlreadyLiked = false;

                        while (reader.Read())
                        { 
                            if (int.Parse(reader["UserID"].ToString()) == Program.UserID)
                            {
                                isAlreadyLiked = true;
                                break;
                            }
                        }

                        if (!isAlreadyLiked)
                        {
                            string insertLikeQuery = "INSERT INTO Likes (PhotoID, UserID) VALUES (@PhotoID, @UserID)";
                            using (SQLiteCommand insertLikeCommand = new SQLiteCommand(insertLikeQuery, connection))
                            {
                                insertLikeCommand.Parameters.AddWithValue("@UserID", Program.UserID);
                                insertLikeCommand.Parameters.AddWithValue("@PhotoID", photoID);

                                insertLikeCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            lblLikesCount.Text = CountLikes().ToString();
        }

        private int CountLikes()
        {
            int likeCount = 0;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string countLikesQuery = "SELECT COUNT(*) FROM Likes WHERE PhotoID = @PhotoID";
                using (SQLiteCommand countLikesCommand = new SQLiteCommand(countLikesQuery, connection))
                {
                    countLikesCommand.Parameters.AddWithValue("@PhotoID", photoID);

                    connection.Open();

                    likeCount = Convert.ToInt32(countLikesCommand.ExecuteScalar());
                }
            }

            return likeCount;
        }
    }
}

