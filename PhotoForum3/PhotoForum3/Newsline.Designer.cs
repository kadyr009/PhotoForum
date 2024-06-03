namespace PhotoForum
{
    partial class Newsline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NewslineLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.NewslineLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPhoto
            // 
            this.AddPhoto.Location = new System.Drawing.Point(3, 0);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(75, 23);
            this.AddPhoto.TabIndex = 0;
            this.AddPhoto.Text = "Add Photo";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPhoto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NewslineLayoutPanel
            // 
            this.NewslineLayoutPanel.AutoScroll = true;
            this.NewslineLayoutPanel.AutoSize = true;
            this.NewslineLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewslineLayoutPanel.Controls.Add(this.button1);
            this.NewslineLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewslineLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.NewslineLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.NewslineLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NewslineLayoutPanel.Name = "NewslineLayoutPanel";
            this.NewslineLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewslineLayoutPanel.Size = new System.Drawing.Size(1130, 533);
            this.NewslineLayoutPanel.TabIndex = 0;
            this.NewslineLayoutPanel.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(3, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Newsline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1130, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewslineLayoutPanel);
            this.Name = "Newsline";
            this.Text = "Newsline";
            this.Load += new System.EventHandler(this.Newsline_Load);
            this.panel1.ResumeLayout(false);
            this.NewslineLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel NewslineLayoutPanel;
        private System.Windows.Forms.Button button1;
    }
}