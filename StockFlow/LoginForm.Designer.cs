namespace StockFlow
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 60);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(97, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(97, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 134);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(140, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(130, 9);
            label3.Name = "label3";
            label3.Size = new Size(196, 41);
            label3.TabIndex = 5;
            label3.Text = "STOCKFLOW";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 310);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockFlow Giriş";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Button btnLogin;
        private Label label3;
    }
}
