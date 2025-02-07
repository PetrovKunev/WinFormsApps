namespace LightToggleText
{
    partial class ToggleText
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
            btnSwitch = new Button();
            lblText = new Label();
            SuspendLayout();
            // 
            // btnSwitch
            // 
            btnSwitch.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitch.Location = new Point(181, 246);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(407, 121);
            btnSwitch.TabIndex = 0;
            btnSwitch.Text = "Turn On/Off";
            btnSwitch.UseVisualStyleBackColor = true;
            btnSwitch.Click += btnSwitch_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblText.Location = new Point(181, 85);
            lblText.Name = "lblText";
            lblText.Size = new Size(0, 65);
            lblText.TabIndex = 1;
            // 
            // ToggleText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblText);
            Controls.Add(btnSwitch);
            Name = "ToggleText";
            Text = "Light Toggle Text";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSwitch;
        private Label lblText;
    }
}
