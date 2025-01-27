namespace SecondWinApp
{
    partial class SecondApp
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
            txtBox = new TextBox();
            btnShow = new Button();
            btnHide = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBox.Location = new Point(12, 44);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(1290, 111);
            txtBox.TabIndex = 0;
            txtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Left;
            btnShow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShow.Location = new Point(12, 299);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(573, 136);
            btnShow.TabIndex = 1;
            btnShow.Text = "Покажи";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.Right;
            btnHide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnHide.Location = new Point(689, 299);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(614, 136);
            btnHide.TabIndex = 2;
            btnHide.Text = "Скрий";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // SecondApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1314, 520);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(txtBox);
            Name = "SecondApp";
            Text = "Second App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btnShow;
        private Button btnHide;
    }
}
