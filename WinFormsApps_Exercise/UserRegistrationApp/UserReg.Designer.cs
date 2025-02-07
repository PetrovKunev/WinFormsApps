namespace UserRegistrationApp
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
            btnRegistration.Location = new Point(281, 229);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(211, 58);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Регистрация";
            btnRegistration.UseVisualStyleBackColor = true;
            // 
            // checkBoxConditions
            // 
            checkBoxConditions.AutoSize = true;
            checkBoxConditions.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxConditions.Location = new Point(83, 62);
            checkBoxConditions.Name = "checkBoxConditions";
            checkBoxConditions.Size = new Size(255, 36);
            checkBoxConditions.TabIndex = 1;
            checkBoxConditions.Text = "Приемам условията";
            checkBoxConditions.UseVisualStyleBackColor = true;
            checkBoxConditions.CheckedChanged += checkBoxConditions_CheckedChanged;
            // 
            // checkBoxAge
            // 
            checkBoxAge.AutoSize = true;
            checkBoxAge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAge.Location = new Point(83, 104);
            checkBoxAge.Name = "checkBoxAge";
            checkBoxAge.Size = new Size(686, 36);
            checkBoxAge.TabIndex = 2;
            checkBoxAge.Text = "Потвърждавам, че съм навършил/а необходимата възраст";
            checkBoxAge.UseVisualStyleBackColor = true;
            checkBoxAge.CheckedChanged += checkBoxAge_CheckedChanged;
            // 
            // UserReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 387);
            Controls.Add(checkBoxAge);
            Controls.Add(checkBoxConditions);
            Controls.Add(btnRegistration);
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
