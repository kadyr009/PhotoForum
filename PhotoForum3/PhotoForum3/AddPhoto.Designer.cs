namespace PhotoForum
{
    partial class AddPhoto
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
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.UploadImage = new System.Windows.Forms.Button();
            this.SelectImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(276, 177);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(100, 20);
            this.txtImagePath.TabIndex = 0;
            // 
            // UploadImage
            // 
            this.UploadImage.Location = new System.Drawing.Point(276, 216);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(75, 23);
            this.UploadImage.TabIndex = 1;
            this.UploadImage.Text = "Upload";
            this.UploadImage.UseVisualStyleBackColor = true;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(382, 177);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(26, 23);
            this.SelectImage.TabIndex = 2;
            this.SelectImage.Text = "...";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // AddPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.UploadImage);
            this.Controls.Add(this.txtImagePath);
            this.Name = "AddPhoto";
            this.Text = "AddPhoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button UploadImage;
        private System.Windows.Forms.Button SelectImage;
    }
}