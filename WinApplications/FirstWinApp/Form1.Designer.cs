
namespace FirstWinApp
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
            txtBox = new TextBox();
            btnShowWords = new Button();
            btnClear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox.BackColor = SystemColors.Info;
            txtBox.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBox.Location = new Point(12, 81);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(1351, 68);
            txtBox.TabIndex = 1;
            // 
            // btnShowWords
            // 
            btnShowWords.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowWords.BackColor = SystemColors.Highlight;
            btnShowWords.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowWords.ForeColor = SystemColors.Control;
            btnShowWords.Location = new Point(12, 343);
            btnShowWords.Name = "btnShowWords";
            btnShowWords.Size = new Size(1350, 103);
            btnShowWords.TabIndex = 2;
            btnShowWords.Text = "Click Me!";
            btnShowWords.UseVisualStyleBackColor = false;
            btnShowWords.Click += btnShowWords_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(12, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(1350, 83);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(286, 50);
            label1.TabIndex = 4;
            label1.Text = "Enter some text:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1374, 513);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnShowWords);
            Controls.Add(txtBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyFirstApp";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox txtBox;
        private Button btnShowWords;
        private Button btnClear;
        private Label label1;
    }
}
