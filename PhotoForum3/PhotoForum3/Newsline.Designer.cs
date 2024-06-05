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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewslineLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.NewslineLayoutPanel);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(28, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1098, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Newsline";
            // 
            // NewslineLayoutPanel
            // 
            this.NewslineLayoutPanel.AutoScroll = true;
            this.NewslineLayoutPanel.AutoSize = true;
            this.NewslineLayoutPanel.BackColor = System.Drawing.Color.Bisque;
            this.NewslineLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewslineLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewslineLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.NewslineLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.NewslineLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NewslineLayoutPanel.Name = "NewslineLayoutPanel";
            this.NewslineLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewslineLayoutPanel.Size = new System.Drawing.Size(1092, 519);
            this.NewslineLayoutPanel.TabIndex = 0;
            this.NewslineLayoutPanel.WrapContents = false;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1130, 533);
            this.tabControl.TabIndex = 0;
            // 
            // Newsline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1130, 533);
            this.Controls.Add(this.tabControl);
            this.Name = "Newsline";
            this.Text = "Newsline";
            this.Load += new System.EventHandler(this.Newsline_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel NewslineLayoutPanel;
        private System.Windows.Forms.TabControl tabControl;
    }
}