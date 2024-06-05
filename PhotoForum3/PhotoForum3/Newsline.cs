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
using System.Windows.Controls;

namespace PhotoForum
{
    public partial class Newsline : Form
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public Newsline()
        {
            InitializeComponent();

            NewslineLayoutPanel.Resize += new EventHandler(NewslineLayoutPanel_Resize);

            AddNewTab("Add Photo", new AddPhoto());
            AddNewTab("My Profile", new Profile());
        }

        private void AddNewTab(string title, Form form)
        {
            TabPage tabPage = new TabPage(title);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            tabPage.Controls.Add(form);
            tabControl.TabPages.Add(tabPage);
            form.Show();
        }

        private void NewslineLayoutPanel_Resize(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in NewslineLayoutPanel.Controls)
            { 
                int horizontalMargin = (NewslineLayoutPanel.ClientSize.Width - control.Width) / 2;

                control.Margin = new Padding(horizontalMargin, control.Margin.Top, horizontalMargin, control.Margin.Bottom);
            }
        }

        private void Newsline_Load(object sender, EventArgs e)
        {
            Program.Newsline = this;

            Update_Newsline();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            AddPhoto addingForm = new AddPhoto();
            addingForm.ShowDialog();
        }

        public void CreatePanel(PhotoControl formsControl)
        {
            NewslineLayoutPanel.Controls.Add(formsControl);
        }

        public void Update_Newsline()
        {
            NewslineLayoutPanel.Controls.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Photos";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PhotoControl photoControl = new PhotoControl
                    {
                        Title = reader["Title"].ToString(),
                        PhotoPath = reader["ImagePath"].ToString(),
                        Description = reader["Description"].ToString(),
                        PhotoID = Convert.ToInt32(reader["PhotoID"]),
                        Width = 375,
                        Height = 320
                    };

                    int horizontalMargin = (NewslineLayoutPanel.ClientSize.Width - photoControl.Width) / 2;

                    photoControl.Margin = new Padding(horizontalMargin, photoControl.Margin.Top, horizontalMargin, photoControl.Margin.Bottom);

                    NewslineLayoutPanel.Controls.Add(photoControl);
                }
            }
        }

        private void addPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhoto addingForm = new AddPhoto();
            addingForm.ShowDialog();
        }
    }
}
