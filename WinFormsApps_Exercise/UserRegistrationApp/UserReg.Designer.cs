﻿namespace UserRegistrationApp
{
    partial class UserReg
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
            btnRegistration = new Button();
            checkBoxConditions = new CheckBox();
            checkBoxAge = new CheckBox();
            SuspendLayout();
            // 
            // btnRegistration
            // 
            btnRegistration.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistration.Location = new Point(522, 489);
            btnRegistration.Margin = new Padding(6, 6, 6, 6);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(392, 124);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Регистрация";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // checkBoxConditions
            // 
            checkBoxConditions.AutoSize = true;
            checkBoxConditions.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxConditions.Location = new Point(154, 132);
            checkBoxConditions.Margin = new Padding(6, 6, 6, 6);
            checkBoxConditions.Name = "checkBoxConditions";
            checkBoxConditions.Size = new Size(499, 69);
            checkBoxConditions.TabIndex = 1;
            checkBoxConditions.Text = "Приемам условията";
            checkBoxConditions.UseVisualStyleBackColor = true;
            checkBoxConditions.CheckedChanged += checkBoxConditions_CheckedChanged;
            // 
            // checkBoxAge
            // 
            checkBoxAge.AutoSize = true;
            checkBoxAge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAge.Location = new Point(154, 222);
            checkBoxAge.Margin = new Padding(6, 6, 6, 6);
            checkBoxAge.Name = "checkBoxAge";
            checkBoxAge.Size = new Size(1353, 69);
            checkBoxAge.TabIndex = 2;
            checkBoxAge.Text = "Потвърждавам, че съм навършил/а необходимата възраст";
            checkBoxAge.UseVisualStyleBackColor = true;
            checkBoxAge.CheckedChanged += checkBoxAge_CheckedChanged;
            // 
            // UserReg
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1749, 826);
            Controls.Add(checkBoxAge);
            Controls.Add(checkBoxConditions);
            Controls.Add(btnRegistration);
            Margin = new Padding(6, 6, 6, 6);
            Name = "UserReg";
            Text = "User Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistration;
        private CheckBox checkBoxConditions;
        private CheckBox checkBoxAge;
    }
}
