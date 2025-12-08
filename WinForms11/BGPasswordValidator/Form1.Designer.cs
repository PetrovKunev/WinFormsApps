namespace BGPasswordValidator
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnAnalyze = new Button();
            btnClear = new Button();
            cmbAccountType = new ComboBox();
            lblResult = new Label();
            progressPassword = new ProgressBar();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(87, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(87, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(322, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(668, 56);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(203, 72);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "Анализирай";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(668, 178);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(203, 72);
            btnClear.TabIndex = 3;
            btnClear.Text = "Изчисти";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbAccountType
            // 
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Гост", "Потребител", "Админ" });
            cmbAccountType.Location = new Point(87, 295);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(182, 33);
            cmbAccountType.TabIndex = 4;
            cmbAccountType.Text = "Потребител";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(87, 432);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 5;
            lblResult.Text = "label1";
            // 
            // progressPassword
            // 
            progressPassword.Location = new Point(87, 518);
            progressPassword.Name = "progressPassword";
            progressPassword.Size = new Size(784, 35);
            progressPassword.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 636);
            Controls.Add(progressPassword);
            Controls.Add(lblResult);
            Controls.Add(cmbAccountType);
            Controls.Add(btnClear);
            Controls.Add(btnAnalyze);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Form1";
            Text = "PasswordValidator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnAnalyze;
        private Button btnClear;
        private ComboBox cmbAccountType;
        private Label lblResult;
        private ProgressBar progressPassword;
    }
}
