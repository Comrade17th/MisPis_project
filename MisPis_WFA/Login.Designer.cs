namespace MisPis_WFA
{
    partial class Login
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_signin = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(107, 87);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(119, 20);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(107, 123);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(119, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(107, 149);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(119, 23);
            this.button_signin.TabIndex = 2;
            this.button_signin.Text = "Войти";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(104, 71);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(104, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
    }
}

