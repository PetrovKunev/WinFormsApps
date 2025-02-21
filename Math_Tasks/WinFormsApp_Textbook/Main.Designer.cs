namespace WinFormsApp_Textbook
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
            rdbGirls = new RadioButton();
            rdbBoys = new RadioButton();
            rdbAll = new RadioButton();
            chkClassA = new CheckBox();
            chkClassB = new CheckBox();
            chkClassV = new CheckBox();
            txtGirlsA = new TextBox();
            txtBoysA = new TextBox();
            txtGirlsB = new TextBox();
            txtBoysV = new TextBox();
            txtGirlsV = new TextBox();
            txtBoysB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnShow = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // rdbGirls
            // 
            rdbGirls.AutoSize = true;
            rdbGirls.Location = new Point(116, 54);
            rdbGirls.Name = "rdbGirls";
            rdbGirls.Size = new Size(161, 36);
            rdbGirls.TabIndex = 0;
            rdbGirls.TabStop = true;
            rdbGirls.Text = "Момичета";
            rdbGirls.UseVisualStyleBackColor = true;
            // 
            // rdbBoys
            // 
            rdbBoys.AutoSize = true;
            rdbBoys.Location = new Point(448, 54);
            rdbBoys.Name = "rdbBoys";
            rdbBoys.Size = new Size(147, 36);
            rdbBoys.TabIndex = 1;
            rdbBoys.TabStop = true;
            rdbBoys.Text = "Момчета";
            rdbBoys.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Location = new Point(809, 54);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(111, 36);
            rdbAll.TabIndex = 2;
            rdbAll.TabStop = true;
            rdbAll.Text = "Общо";
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // chkClassA
            // 
            chkClassA.AutoSize = true;
            chkClassA.Location = new Point(116, 221);
            chkClassA.Name = "chkClassA";
            chkClassA.Size = new Size(129, 36);
            chkClassA.TabIndex = 3;
            chkClassA.Text = "8А клас";
            chkClassA.UseVisualStyleBackColor = true;
            // 
            // chkClassB
            // 
            chkClassB.AutoSize = true;
            chkClassB.Location = new Point(116, 309);
            chkClassB.Name = "chkClassB";
            chkClassB.Size = new Size(128, 36);
            chkClassB.TabIndex = 4;
            chkClassB.Text = "8Б клас";
            chkClassB.UseVisualStyleBackColor = true;
            // 
            // chkClassV
            // 
            chkClassV.AutoSize = true;
            chkClassV.Location = new Point(116, 396);
            chkClassV.Name = "chkClassV";
            chkClassV.Size = new Size(128, 36);
            chkClassV.TabIndex = 5;
            chkClassV.Text = "8В клас";
            chkClassV.UseVisualStyleBackColor = true;
            // 
            // txtGirlsA
            // 
            txtGirlsA.Location = new Point(422, 218);
            txtGirlsA.Name = "txtGirlsA";
            txtGirlsA.Size = new Size(173, 39);
            txtGirlsA.TabIndex = 6;
            // 
            // txtBoysA
            // 
            txtBoysA.Location = new Point(747, 218);
            txtBoysA.Name = "txtBoysA";
            txtBoysA.Size = new Size(173, 39);
            txtBoysA.TabIndex = 7;
            // 
            // txtGirlsB
            // 
            txtGirlsB.Location = new Point(422, 306);
            txtGirlsB.Name = "txtGirlsB";
            txtGirlsB.Size = new Size(173, 39);
            txtGirlsB.TabIndex = 8;
            // 
            // txtBoysV
            // 
            txtBoysV.Location = new Point(747, 393);
            txtBoysV.Name = "txtBoysV";
            txtBoysV.Size = new Size(173, 39);
            txtBoysV.TabIndex = 9;
            // 
            // txtGirlsV
            // 
            txtGirlsV.Location = new Point(422, 393);
            txtGirlsV.Name = "txtGirlsV";
            txtGirlsV.Size = new Size(173, 39);
            txtGirlsV.TabIndex = 10;
            // 
            // txtBoysB
            // 
            txtBoysB.Location = new Point(747, 306);
            txtBoysB.Name = "txtBoysB";
            txtBoysB.Size = new Size(173, 39);
            txtBoysB.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 157);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 12;
            label1.Text = "Момичета";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(773, 157);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 13;
            label2.Text = "Момчета";
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Calibri", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShow.Location = new Point(116, 529);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(378, 73);
            btnShow.TabIndex = 14;
            btnShow.Text = "Покажи";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(707, 570);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(104, 32);
            lblResult.TabIndex = 15;
            lblResult.Text = "_________";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 656);
            Controls.Add(lblResult);
            Controls.Add(btnShow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoysB);
            Controls.Add(txtGirlsV);
            Controls.Add(txtBoysV);
            Controls.Add(txtGirlsB);
            Controls.Add(txtBoysA);
            Controls.Add(txtGirlsA);
            Controls.Add(chkClassV);
            Controls.Add(chkClassB);
            Controls.Add(chkClassA);
            Controls.Add(rdbAll);
            Controls.Add(rdbBoys);
            Controls.Add(rdbGirls);
            Name = "Main";
            Text = "Count";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbGirls;
        private RadioButton rdbBoys;
        private RadioButton rdbAll;
        private CheckBox chkClassA;
        private CheckBox chkClassB;
        private CheckBox chkClassV;
        private TextBox txtGirlsA;
        private TextBox txtBoysA;
        private TextBox txtGirlsB;
        private TextBox txtBoysV;
        private TextBox txtGirlsV;
        private TextBox txtBoysB;
        private Label label1;
        private Label label2;
        private Button btnShow;
        private Label lblResult;
    }
}
