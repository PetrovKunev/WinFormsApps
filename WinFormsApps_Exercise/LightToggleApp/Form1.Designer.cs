namespace LightToggleApp
{
    partial class LightToggle
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
            btnToggle = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnToggle
            // 
            btnToggle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToggle.Location = new Point(116, 166);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(210, 76);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "Превключи светлината";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(152, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 1;
            // 
            // LightToggle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 303);
            Controls.Add(lblStatus);
            Controls.Add(btnToggle);
            Name = "LightToggle";
            Text = "Light Toggle";
            Load += LightToggle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnToggle;
        private Label lblStatus;
    }
}
