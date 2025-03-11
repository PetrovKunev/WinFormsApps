namespace Main
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
            cmbFoodList = new ComboBox();
            txtPortion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddFood = new Button();
            dgvMealSummary = new DataGridView();
            lblTotalCalories = new Label();
            lblTotalProtein = new Label();
            lblTotalFat = new Label();
            lblTotalCarbs = new Label();
            label7 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMealSummary).BeginInit();
            SuspendLayout();
            // 
            // cmbFoodList
            // 
            cmbFoodList.FormattingEnabled = true;
            cmbFoodList.Location = new Point(99, 86);
            cmbFoodList.Name = "cmbFoodList";
            cmbFoodList.Size = new Size(446, 40);
            cmbFoodList.TabIndex = 0;
            // 
            // txtPortion
            // 
            txtPortion.Location = new Point(804, 86);
            txtPortion.Name = "txtPortion";
            txtPortion.Size = new Size(362, 39);
            txtPortion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(802, 38);
            label1.Name = "label1";
            label1.Size = new Size(364, 32);
            label1.TabIndex = 2;
            label1.Text = "Въведи количеството (в грама):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 38);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 3;
            label2.Text = "Списък с храни: ";
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(1338, 68);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(366, 74);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "Добави храната";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // dgvMealSummary
            // 
            dgvMealSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealSummary.Location = new Point(99, 278);
            dgvMealSummary.Name = "dgvMealSummary";
            dgvMealSummary.RowHeadersWidth = 82;
            dgvMealSummary.Size = new Size(1605, 279);
            dgvMealSummary.TabIndex = 5;
            // 
            // lblTotalCalories
            // 
            lblTotalCalories.AutoSize = true;
            lblTotalCalories.Location = new Point(300, 739);
            lblTotalCalories.Name = "lblTotalCalories";
            lblTotalCalories.Size = new Size(84, 32);
            lblTotalCalories.TabIndex = 6;
            lblTotalCalories.Text = "_______";
            // 
            // lblTotalProtein
            // 
            lblTotalProtein.AutoSize = true;
            lblTotalProtein.Location = new Point(675, 739);
            lblTotalProtein.Name = "lblTotalProtein";
            lblTotalProtein.Size = new Size(94, 32);
            lblTotalProtein.TabIndex = 7;
            lblTotalProtein.Text = "________";
            // 
            // lblTotalFat
            // 
            lblTotalFat.AutoSize = true;
            lblTotalFat.Location = new Point(1088, 745);
            lblTotalFat.Name = "lblTotalFat";
            lblTotalFat.Size = new Size(84, 32);
            lblTotalFat.TabIndex = 8;
            lblTotalFat.Text = "_______";
            // 
            // lblTotalCarbs
            // 
            lblTotalCarbs.AutoSize = true;
            lblTotalCarbs.Location = new Point(1610, 745);
            lblTotalCarbs.Name = "lblTotalCarbs";
            lblTotalCarbs.Size = new Size(94, 32);
            lblTotalCarbs.TabIndex = 9;
            lblTotalCarbs.Text = "________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(99, 739);
            label7.Name = "label7";
            label7.Size = new Size(185, 32);
            label7.TabIndex = 10;
            label7.Text = "Общо калории:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 739);
            label3.Name = "label3";
            label3.Size = new Size(199, 32);
            label3.TabIndex = 11;
            label3.Text = "Общо протеини:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(876, 745);
            label8.Name = "label8";
            label8.Size = new Size(188, 32);
            label8.TabIndex = 12;
            label8.Text = "Общо мазнини:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1347, 745);
            label4.Name = "label4";
            label4.Size = new Size(242, 32);
            label4.TabIndex = 13;
            label4.Text = "Общо въглехидрати:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1826, 886);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(lblTotalCarbs);
            Controls.Add(lblTotalFat);
            Controls.Add(lblTotalProtein);
            Controls.Add(lblTotalCalories);
            Controls.Add(dgvMealSummary);
            Controls.Add(btnAddFood);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPortion);
            Controls.Add(cmbFoodList);
            Name = "Form1";
            Text = "GutsGrind";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMealSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFoodList;
        private TextBox txtPortion;
        private Label label1;
        private Label label2;
        private Button btnAddFood;
        private DataGridView dgvMealSummary;
        private Label lblTotalCalories;
        private Label lblTotalProtein;
        private Label lblTotalFat;
        private Label lblTotalCarbs;
        private Label label7;
        private Label label3;
        private Label label8;
        private Label label4;
    }
}
