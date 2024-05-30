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
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using System.Windows;
using System.Drawing.Imaging;

namespace PhotoForum
{
    public partial class AddPhoto : Form
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public AddPhoto()
        {
            InitializeComponent();
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog.FileName;
            }
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
            string imagePath = txtImagePath.Text;

            if (string.IsNullOrEmpty(imagePath))
            {
                System.Windows.MessageBox.Show("Please select an image file.");
                return;
            }

            string title = "Sample Title";
            string description = "Sample Description";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Photos (UserID, Title, Description, DateUploaded, ImagePath) VALUES (@UserID, @Title, @Description, @DateUploaded, @ImagePath)";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@UserID", Program.userID);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@DateUploaded", DateTime.Now);
                command.Parameters.AddWithValue("@ImagePath", imagePath);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    System.Windows.MessageBox.Show("Image uploaded successfully!");

                    this.Hide();
                    Program.newsline.Update_Newsline();
                    Program.newsline.Show();
                    this.Close();
                }
                else
                {
                    System.Windows.MessageBox.Show("Error occurred while uploading the image.");
                }
            }
        }
    }
}
