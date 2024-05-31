namespace PhotoForum
{
    partial class PhotoControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoControl));
            this.lblLikesCount = new System.Windows.Forms.Label();
            this.ShowComments = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LikeBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLikesCount
            // 
            this.lblLikesCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLikesCount.AutoSize = true;
            this.lblLikesCount.Location = new System.Drawing.Point(40, 13);
            this.lblLikesCount.Name = "lblLikesCount";
            this.lblLikesCount.Size = new System.Drawing.Size(35, 13);
            this.lblLikesCount.TabIndex = 1;
            this.lblLikesCount.Text = "label1";
            // 
            // ShowComments
            // 
            this.ShowComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowComments.Location = new System.Drawing.Point(191, 8);
            this.ShowComments.Name = "ShowComments";
            this.ShowComments.Size = new System.Drawing.Size(75, 23);
            this.ShowComments.TabIndex = 2;
            this.ShowComments.Text = "Comments";
            this.ShowComments.UseVisualStyleBackColor = true;
            this.ShowComments.Click += new System.EventHandler(this.ShowComments_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LikeBut);
            this.panel1.Controls.Add(this.lblLikesCount);
            this.panel1.Controls.Add(this.ShowComments);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 63);
            this.panel1.TabIndex = 4;
            // 
            // LikeBut
            // 
            this.LikeBut.Location = new System.Drawing.Point(81, 8);
            this.LikeBut.Name = "LikeBut";
            this.LikeBut.Size = new System.Drawing.Size(75, 23);
            this.LikeBut.TabIndex = 4;
            this.LikeBut.Text = "Like";
            this.LikeBut.UseVisualStyleBackColor = true;
            this.LikeBut.Click += new System.EventHandler(this.LikeBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 257);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // PhotoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PhotoControl";
            this.Size = new System.Drawing.Size(372, 320);
            this.Load += new System.EventHandler(this.PhotoControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLikesCount;
        private System.Windows.Forms.Button ShowComments;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LikeBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
