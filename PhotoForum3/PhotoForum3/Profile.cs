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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhotoForum
{
    public partial class Profile : Form
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public Profile()
        {
            InitializeComponent();

            contentPanel.Resize += new EventHandler(ContentPanel_Resize);
        }

        private void ContentPanel_Resize(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in contentPanel.Controls)
            {
                int horizontalMargin = (contentPanel.ClientSize.Width - control.Width) / 2;

                control.Margin = new Padding(horizontalMargin, control.Margin.Top, horizontalMargin, control.Margin.Bottom);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();

            InitializeUser();

            Update_Content();
        }

        private void InitializeUser()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", Program.UserID);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtUserName.Text = reader["Username"].ToString();
                        txtRole.Text = reader["Role"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                    }
                }
            }
        }

        public void Update_Content()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Photos WHERE UserID = @UserID";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", Program.UserID);

                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("RRRRRR");
                        PhotoControl photoControl = new PhotoControl
                        {
                            Title = reader["Title"].ToString(),
                            PhotoPath = reader["ImagePath"].ToString(),
                            Description = reader["Description"].ToString(),
                            PhotoID = Convert.ToInt32(reader["PhotoID"]),
                            Width = 375,
                            Height = 320
                        };

                        int horizontalMargin = (contentPanel.ClientSize.Width - photoControl.Width) / 2;

                        photoControl.Margin = new Padding(horizontalMargin, photoControl.Margin.Top, horizontalMargin, photoControl.Margin.Bottom);

                        contentPanel.Controls.Add(photoControl);
                    }
                }
            }
        }
    }
}
