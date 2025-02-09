namespace DayNight
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
            radioBtnDay = new RadioButton();
            radioBtnNight = new RadioButton();
            SuspendLayout();
            // 
            // radioBtnDay
            // 
            radioBtnDay.AutoSize = true;
            radioBtnDay.Location = new Point(329, 121);
            radioBtnDay.Name = "radioBtnDay";
            radioBtnDay.Size = new Size(45, 19);
            radioBtnDay.TabIndex = 0;
            radioBtnDay.TabStop = true;
            radioBtnDay.Text = "Day";
            radioBtnDay.UseVisualStyleBackColor = true;
            radioBtnDay.CheckedChanged += radioButtonDay_CheckedChanged;
            // 
            // radioBtnNight
            // 
            radioBtnNight.AutoSize = true;
            radioBtnNight.Location = new Point(329, 179);
            radioBtnNight.Name = "radioBtnNight";
            radioBtnNight.Size = new Size(55, 19);
            radioBtnNight.TabIndex = 1;
            radioBtnNight.TabStop = true;
            radioBtnNight.Text = "Night";
            radioBtnNight.UseVisualStyleBackColor = true;
            radioBtnNight.CheckedChanged += radioButtonNight_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(radioBtnNight);
            Controls.Add(radioBtnDay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Day and Night";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBtnDay;
        private RadioButton radioBtnNight;
    }
}
