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
    public partial class Liked : Form
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public Liked()
        {
            InitializeComponent();

            flowLayoutPanel1.Resize += new EventHandler(ContentPanel_Resize);
        }

        private void Liked_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            Update_Content();
        }

        private void ContentPanel_Resize(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in flowLayoutPanel1.Controls)
            {
                int horizontalMargin = (flowLayoutPanel1.ClientSize.Width - control.Width) / 2;

                control.Margin = new Padding(horizontalMargin, control.Margin.Top, horizontalMargin, control.Margin.Bottom);
            }
        }

        public void Update_Content()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Likes WHERE UserID = @UserID";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", Program.UserID);

                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string selectPhotoQuery = "SELECT * FROM Photos WHERE PhotoID = @PhotoID";
                        using (SQLiteCommand selectPhotoCommand = new SQLiteCommand(selectPhotoQuery, connection))
                        {
                            selectPhotoCommand.Parameters.AddWithValue("@PhotoID", Convert.ToInt32(reader["PhotoID"]));

                            using (SQLiteDataReader selectPhotoReader = selectPhotoCommand.ExecuteReader())
                            {
                                while (selectPhotoReader.Read())
                                {
                                    PhotoControl photoControl = new PhotoControl
                                    {
                                        Title = selectPhotoReader["Title"].ToString(),
                                        PhotoPath = selectPhotoReader["ImagePath"].ToString(),
                                        Description = selectPhotoReader["Description"].ToString(),
                                        PhotoID = Convert.ToInt32(selectPhotoReader["PhotoID"]),
                                        Width = 375,
                                        Height = 320
                                    };

                                    int horizontalMargin = (flowLayoutPanel1.ClientSize.Width - photoControl.Width) / 2;

                                    photoControl.Margin = new Padding(horizontalMargin, photoControl.Margin.Top, horizontalMargin, photoControl.Margin.Bottom);

                                    flowLayoutPanel1.Controls.Add(photoControl);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
