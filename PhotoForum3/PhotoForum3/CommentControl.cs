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
    public partial class CommentControl : UserControl
    {
        private string connectionString = "Data Source=PhotoForumDB.sqlite;";

        public CommentControl()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Comment
        {
            get { return txtComment.Text; }
            set { txtComment.Text = value; }
        }

        public string Date
        {
            get { return txtDate.Text; }
            set { txtDate.Text = value; }
        }

        private void CommentControl_Load(object sender, EventArgs e)
        {

        }
    }
}
