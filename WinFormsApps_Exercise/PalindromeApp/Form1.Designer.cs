namespace PalindromeApp
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
            txtInput = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(187, 81);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(474, 39);
            txtInput.TabIndex = 0;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Calibri", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCheck.Location = new Point(187, 248);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(474, 117);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "CHECK";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(154, 479);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 64);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 637);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Palindrome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCheck;
        private Label lblResult;
    }
}
