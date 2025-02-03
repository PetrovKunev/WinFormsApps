namespace WinFormsApps_Exercise
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
            btnCalculate = new Button();
            label2 = new Label();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtInput.Location = new Point(54, 106);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(914, 110);
            txtInput.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(192, 255, 192);
            btnCalculate.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCalculate.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculate.Location = new Point(54, 314);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(475, 91);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate area";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(308, 502);
            label2.Name = "label2";
            label2.Size = new Size(193, 65);
            label2.TabIndex = 3;
            label2.Text = "Area is: ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(619, 502);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(168, 65);
            lblResult.TabIndex = 4;
            lblResult.Text = "_______";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Turquoise;
            btnClear.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(544, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(424, 91);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 634);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Square";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Button btnCalculate;
        private Label label2;
        private Label lblResult;
        private Button btnClear;
    }
}
