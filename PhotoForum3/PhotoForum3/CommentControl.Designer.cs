namespace PhotoForum
{
    partial class CommentControl
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
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(17, 14);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(35, 13);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "label1";
            // 
            // txtComment
            // 
            this.txtComment.AutoSize = true;
            this.txtComment.Location = new System.Drawing.Point(17, 55);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(35, 13);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "label1";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(269, 142);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(35, 13);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "label1";
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtUserName);
            this.Name = "CommentControl";
            this.Size = new System.Drawing.Size(403, 174);
            this.Load += new System.EventHandler(this.CommentControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtComment;
        private System.Windows.Forms.Label txtDate;
    }
}
