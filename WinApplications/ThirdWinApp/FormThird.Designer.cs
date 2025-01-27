namespace ThirdWinApp
{
    partial class FormThird
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
            lblWords = new Label();
            txtBox = new TextBox();
            btnWords = new Button();
            SuspendLayout();
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWords.Location = new Point(712, 83);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(0, 86);
            lblWords.TabIndex = 0;
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBox.Location = new Point(115, 80);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(351, 103);
            txtBox.TabIndex = 1;
            // 
            // btnWords
            // 
            btnWords.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnWords.Location = new Point(260, 341);
            btnWords.Name = "btnWords";
            btnWords.Size = new Size(584, 140);
            btnWords.TabIndex = 2;
            btnWords.Text = "С думи";
            btnWords.UseVisualStyleBackColor = true;
            btnWords.Click += btnWords_Click;
            // 
            // FormThird
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1075, 592);
            Controls.Add(btnWords);
            Controls.Add(txtBox);
            Controls.Add(lblWords);
            Name = "FormThird";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Third App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWords;
        private TextBox txtBox;
        private Button btnWords;
    }
}
