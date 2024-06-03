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

namespace PhotoForum
{
    public partial class CommentWrite : UserControl
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";
        private int photoID = -1;

        public int PhotoID
        {
            get { return photoID; }
            set { photoID = value; }
        }

        public CommentWrite()
        {
            InitializeComponent();
        }

        private void Submit_But_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertCommentQuery = "INSERT INTO Comments (PhotoID, UserID, CommentText) VALUES (@PhotoID, @UserID, @CommentText)";
                using (SQLiteCommand insertLCommentCommand = new SQLiteCommand(insertCommentQuery, connection))
                {
                    insertLCommentCommand.Parameters.AddWithValue("@UserID", Program.UserID);
                    insertLCommentCommand.Parameters.AddWithValue("@PhotoID", photoID);
                    insertLCommentCommand.Parameters.AddWithValue("@CommentText", textBox.Text);

                    insertLCommentCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
