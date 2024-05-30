namespace PhotoForum
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Login_But = new System.Windows.Forms.Button();
            this.Regis_But = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(344, 136);
            this.txtUsername.MaximumSize = new System.Drawing.Size(200, 20);
            this.txtUsername.MinimumSize = new System.Drawing.Size(30, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(344, 162);
            this.txtPassword.MaximumSize = new System.Drawing.Size(200, 20);
            this.txtPassword.MinimumSize = new System.Drawing.Size(30, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // Login_But
            // 
            this.Login_But.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_But.AutoSize = true;
            this.Login_But.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_But.Location = new System.Drawing.Point(356, 230);
            this.Login_But.MaximumSize = new System.Drawing.Size(87, 32);
            this.Login_But.MinimumSize = new System.Drawing.Size(87, 32);
            this.Login_But.Name = "Login_But";
            this.Login_But.Size = new System.Drawing.Size(87, 32);
            this.Login_But.TabIndex = 2;
            this.Login_But.Text = "Login";
            this.Login_But.UseVisualStyleBackColor = true;
            this.Login_But.Click += new System.EventHandler(this.Login_But_Click);
            // 
            // Regis_But
            // 
            this.Regis_But.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Regis_But.AutoSize = true;
            this.Regis_But.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Regis_But.Location = new System.Drawing.Point(356, 259);
            this.Regis_But.MaximumSize = new System.Drawing.Size(87, 32);
            this.Regis_But.MinimumSize = new System.Drawing.Size(87, 32);
            this.Regis_But.Name = "Regis_But";
            this.Regis_But.Size = new System.Drawing.Size(87, 32);
            this.Regis_But.TabIndex = 3;
            this.Regis_But.Text = "Registration";
            this.Regis_But.UseVisualStyleBackColor = true;
            this.Regis_But.Click += new System.EventHandler(this.Regis_But_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(344, 188);
            this.txtEmail.MaximumSize = new System.Drawing.Size(200, 20);
            this.txtEmail.MinimumSize = new System.Drawing.Size(30, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 439);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Regis_But);
            this.Controls.Add(this.Login_But);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button Login_But;
        private System.Windows.Forms.Button Regis_But;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

