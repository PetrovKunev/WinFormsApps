namespace PasswordCheckerApp
{
    partial class Form1
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
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(184, 121);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(698, 39);
            txtBoxPassword.TabIndex = 0;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Calibri", 28F);
            btnLogin.Location = new Point(362, 361);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(355, 100);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Calibri", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMessage.Location = new Point(362, 243);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 53);
            lblMessage.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 575);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Name = "Form1";
            Text = "Password Checker App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPassword;
        private Button btnLogin;
        private Label lblMessage;
    }
}
