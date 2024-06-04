namespace PhotoForum
{
    partial class CommentWrite
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.Submit_But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(373, 20);
            this.textBox.TabIndex = 0;
            // 
            // Submit_But
            // 
            this.Submit_But.Dock = System.Windows.Forms.DockStyle.Right;
            this.Submit_But.Location = new System.Drawing.Point(273, 0);
            this.Submit_But.Name = "Submit_But";
            this.Submit_But.Size = new System.Drawing.Size(100, 19);
            this.Submit_But.TabIndex = 1;
            this.Submit_But.Text = "Submit";
            this.Submit_But.UseVisualStyleBackColor = true;
            this.Submit_But.Click += new System.EventHandler(this.Submit_But_Click);
            // 
            // CommentWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Submit_But);
            this.Controls.Add(this.textBox);
            this.MaximumSize = new System.Drawing.Size(375, 21);
            this.Name = "CommentWrite";
            this.Size = new System.Drawing.Size(373, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Submit_But;
    }
}
