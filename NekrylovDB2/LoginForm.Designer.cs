namespace NekrylovDB2
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();

            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLogin.Hint = "Логин";
            this.txtLogin.Location = new System.Drawing.Point(50, 100);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(300, 50);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "";

            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPassword.Hint = "Пароль";
            this.txtPassword.Location = new System.Drawing.Point(50, 170);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true; // Скрытие ввода пароля
            this.txtPassword.Size = new System.Drawing.Size(300, 50);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "";

            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.Depth = 0;
            this.btnLogin.DrawShadows = true;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(50, 240);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.Depth = 0;
            this.btnCancel.DrawShadows = true;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(220, 240);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
        }
    }
}