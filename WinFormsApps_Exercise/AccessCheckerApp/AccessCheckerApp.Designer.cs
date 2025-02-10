namespace AccessCheckerApp
{
    partial class AccessCheckerApp
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
            checkBoxAccess = new CheckBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // checkBoxAccess
            // 
            checkBoxAccess.AutoSize = true;
            checkBoxAccess.Location = new Point(126, 107);
            checkBoxAccess.Margin = new Padding(6);
            checkBoxAccess.Name = "checkBoxAccess";
            checkBoxAccess.Size = new Size(126, 36);
            checkBoxAccess.TabIndex = 0;
            checkBoxAccess.Text = "Достъп";
            checkBoxAccess.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(126, 335);
            btnCheck.Margin = new Padding(6);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(318, 107);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Проверка";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(236, 555);
            lblResult.Margin = new Padding(6, 0, 6, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 32);
            lblResult.TabIndex = 2;
            // 
            // AccessCheckerApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 658);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(checkBoxAccess);
            Margin = new Padding(6);
            Name = "AccessCheckerApp";
            Text = "AccessCheckerApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxAccess;
        private Button btnCheck;
        private Label lblResult;
    }
}
