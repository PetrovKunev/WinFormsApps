namespace FourthFormApp
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
            btnCalculateArea = new Button();
            txtInputBox = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalculateArea
            // 
            btnCalculateArea.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCalculateArea.Location = new Point(44, 258);
            btnCalculateArea.Name = "btnCalculateArea";
            btnCalculateArea.Size = new Size(629, 87);
            btnCalculateArea.TabIndex = 0;
            btnCalculateArea.Text = "Изчисли лицето";
            btnCalculateArea.UseVisualStyleBackColor = true;
            btnCalculateArea.Click += btnCalculateArea_Click;
            // 
            // txtInputBox
            // 
            txtInputBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtInputBox.Location = new Point(44, 114);
            txtInputBox.Multiline = true;
            txtInputBox.Name = "txtInputBox";
            txtInputBox.Size = new Size(314, 75);
            txtInputBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 3;
            label1.Text = "Въведи страна на квадрат:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(499, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(97, 59);
            lblResult.TabIndex = 4;
            lblResult.Text = "____";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 44);
            label2.Name = "label2";
            label2.Size = new Size(258, 32);
            label2.TabIndex = 5;
            label2.Text = "Лицето на квадрата е:";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtInputBox);
            Controls.Add(btnCalculateArea);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изчисляване на лице на квадрат";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateArea;
        private TextBox txtInputBox;
        private Label label1;
        private Label lblResult;
        private Label label2;
    }
}
