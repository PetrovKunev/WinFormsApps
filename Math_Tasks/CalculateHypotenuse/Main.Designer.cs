namespace CalculateHypotenuse
{
    partial class Main
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
            txtCadetA = new TextBox();
            txtCadetB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            lblResult = new Label();
            pictureBox1 = new PictureBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCadetA
            // 
            txtCadetA.Location = new Point(106, 160);
            txtCadetA.Name = "txtCadetA";
            txtCadetA.Size = new Size(348, 39);
            txtCadetA.TabIndex = 0;
            // 
            // txtCadetB
            // 
            txtCadetB.Location = new Point(106, 354);
            txtCadetB.Name = "txtCadetB";
            txtCadetB.Size = new Size(339, 39);
            txtCadetB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 80);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 2;
            label1.Text = "Insert cadet A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 264);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 3;
            label2.Text = "Insert cadet B";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(106, 645);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(339, 84);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(925, 676);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(212, 53);
            lblResult.TabIndex = 5;
            lblResult.Text = "_________";
            lblResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Pythagorean_Theorem;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(760, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 406);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(512, 645);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(186, 84);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 833);
            Controls.Add(btnClear);
            Controls.Add(pictureBox1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCadetB);
            Controls.Add(txtCadetA);
            Margin = new Padding(6);
            Name = "Main";
            Text = "Pythagorean theorem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCadetA;
        private TextBox txtCadetB;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Label lblResult;
        private PictureBox pictureBox1;
        private Button btnClear;
    }
}
